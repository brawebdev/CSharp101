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
        private List<decimal> _transaction = new List<decimal>();

        public void Add(decimal money)
        {
            _transaction.Add(money);
            _balance += money;
        }

        public decimal Get()
        {
            return _balance;
        }

        public void Revert(int transactionNumber)
        {
            decimal transaction = _transaction[transactionNumber];

            if (transaction > 0)
                Subtract(transaction);
            else if (transaction < 0)
            {
                transaction *= -1;
                Add(transaction);
            }
            else
                throw new ArgumentNullException("The selected transaction does not exist.");
        }

        public void Subtract(decimal money)
        {
            _transaction.Add(-money);
            _balance -= money;
        } 
    }
}
