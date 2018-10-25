using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_2.Receiver
{
    class CheckingAccount : IBankAccount
    {
        private decimal _balance = 0;

        public void Add(decimal money)
        {
            _balance += money;
        }

        public decimal Get()
        {
            return _balance;
        }

        public void Subtract(decimal money)
        {
            _balance -= money;
        } 
    }
}
