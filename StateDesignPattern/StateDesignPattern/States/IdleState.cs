using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using StateDesignPattern.Context;
using StateDesignPattern.Interface;

namespace StateDesignPattern.States
{
    internal class IdleState
    {
        public void InsertMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("Money inserted. Transitioning to MoneyInterfaceState.");
            vendingMachine.SetState(new MoneyInterfaceState());
        }
        public void SelectProduct(VendingMachine vendingMachine)
        {
            Console.WriteLine("Cannot select product. Please insert money first.");
            vendingMachine.SetState(new IdleState());
        }
    }
}
