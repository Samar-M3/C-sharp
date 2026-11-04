using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPattern.Context;

namespace StateDesignPattern.Interface
{
    internal interface IVendingMachine
    {
        void InsertMoney(VendingMachine machine);
        void SelectProduct(VendingMachine machine);
    }
}
