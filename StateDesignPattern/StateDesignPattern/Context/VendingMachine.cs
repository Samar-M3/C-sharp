using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPattern.Interface;
using StateDesignPattern.States;

namespace StateDesignPattern.Context
{
    internal class VendingMachine
    {
        private IVendingMachine _currentState;
        public VendingMachine()
        {
            _currentState = new IdleState();
        }

        public void SetState(IVendingMachine state)
        {
            _currentState = state;
        }

        public void SelectProduct()
        {
            _currentState.SelectProduct(this);
        }

        public void  Reset()
        {
            _currentState = new IdleState();
        }

        internal void SetState(MoneyInterfaceState moneyInterfaceState)
        {
            throw new NotImplementedException();
        }

        internal void SetState(IdleState idleState)
        {
            throw new NotImplementedException();
        }

        internal void InsertMoney()
        {
            throw new NotImplementedException();
        }
    }
}
