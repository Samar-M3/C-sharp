using System;
using System.Collections.Generic;

namespace MiniCheckout
{
    
    public class CartItem
    {
        public string Name { get; }
        public int Qty { get; }
        public decimal Price { get; }

        public CartItem(string name, int qty, decimal price)
        {
            Name = name;
            Qty = qty;
            Price = price;
        }

        public decimal LineTotal() => Qty * Price;
    }

    public class Cart
    {
        private readonly List<CartItem> _items = new List<CartItem>();

        public IReadOnlyList<CartItem> Items => _items;

        public void Add(CartItem item) => _items.Add(item);

        // The only place where the subtotal is calculated.
        public decimal Subtotal()
        {
            decimal subtotal = 0;
            foreach (var item in _items)
            {
                subtotal += item.LineTotal();
            }
            return subtotal;
        }
    }

    public interface IDiscountStrategy
    {
        decimal Calculate(decimal subtotal);
    }

    public class PercentDiscount : IDiscountStrategy
    {
        private readonly decimal _rate; // 0.10m = 10%

        public PercentDiscount(decimal rate)
        {
            _rate = rate;
        }

        public decimal Calculate(decimal subtotal) => subtotal * _rate;
    }

    public class FlatDiscount : IDiscountStrategy
    {
        private readonly decimal _amount;

        public FlatDiscount(decimal amount)
        {
            _amount = amount;
        }

        public decimal Calculate(decimal subtotal) => Math.Min(_amount, subtotal);
    }

    public interface IPrinter
    {
        void Print(Cart cart, decimal subtotal, decimal discount, decimal total);
    }

    // Prints only. No calculations here.
    public class ReceiptPrinter : IPrinter
    {
        public void Print(Cart cart, decimal subtotal, decimal discount, decimal total)
        {
            Console.WriteLine("=== RECEIPT ===");
            foreach (var item in cart.Items)
            {
                Console.WriteLine($"{item.Qty}x {item.Name} @ {item.Price} = {item.LineTotal()}");
            }
            Console.WriteLine($"Subtotal: {subtotal}");
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"TOTAL   : {total}");
        }
    }


    public class CheckoutResult
    {
        public decimal Subtotal { get; }
        public decimal Discount { get; }
        public decimal Total { get; }

        public CheckoutResult(decimal subtotal, decimal discount, decimal total)
        {
            Subtotal = subtotal;
            Discount = discount;
            Total = total;
        }
    }


    public class CheckoutService
    {
        private readonly IDiscountStrategy _discountStrategy;
        private readonly IPrinter _printer;

        public CheckoutService(IDiscountStrategy discountStrategy, IPrinter printer)
        {
            _discountStrategy = discountStrategy;
            _printer = printer;
        }

        public CheckoutResult Checkout(Cart cart)
        {
            decimal subtotal = cart.Subtotal();
            decimal discount = _discountStrategy.Calculate(subtotal);
            decimal total = subtotal - discount;

            _printer.Print(cart, subtotal, discount, total);

            return new CheckoutResult(subtotal, discount, total);
        }
    }

    class Program
    {
        static void Main()
        {
            var cart = new Cart();
            cart.Add(new CartItem("Pen", 2, 50m));
            cart.Add(new CartItem("Notebook", 1, 200m));

            IDiscountStrategy discount = new PercentDiscount(0.10m);

            IPrinter printer = new ReceiptPrinter();

            var checkout = new CheckoutService(discount, printer);
            checkout.Checkout(cart);
        }
    }
}