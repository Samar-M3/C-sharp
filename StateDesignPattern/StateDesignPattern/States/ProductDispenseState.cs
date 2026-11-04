using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPattern.Context;
using StateDesignPattern.Interface;

namespace StateDesignPattern.States
{
    internal class ProductDispenseState: IVendingMachine
    {
        public void InsertMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("Cannot insert money. Dispensing product.");
        }

        public void SelectProduct(VendingMachine vendingMachine)
        {
            Console.WriteLine("Cannot select product. Dispensing product.");
        }
    }
}
