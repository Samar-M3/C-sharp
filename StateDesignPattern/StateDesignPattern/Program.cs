using StateDesignPattern.Context;

namespace StateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to the Vending Machine!");
            VendingMachine machine = new VendingMachine();

            machine.SelectProduct();
            machine.InsertMoney();
            machine.InsertMoney();
            machine.SelectProduct();
            machine.InsertMoney();
            machine.SelectProduct();

            machine.Reset();

            machine.SelectProduct();
            machine.InsertMoney();
        }
    }
}
