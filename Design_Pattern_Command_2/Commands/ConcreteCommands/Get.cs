using Design_Pattern_Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_2.Commands.ConcreteCommands
{
    class Get : ICommand
    {
        private IBankAccount _bankAccount;

        public Get(IBankAccount bankAccount)
        {
            _bankAccount = bankAccount;
        }

        public decimal Execute()
        {
           return _bankAccount.Get();
        }

        public void Execute(int transactionNumber)
        {
        }

        public void Execute(decimal money)
        {
        }
    }
}
