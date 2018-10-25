using Design_Pattern_Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_2.Commands.ConcreteCommands
{
    class Revert : ICommand
    {
        private IBankAccount _bankAccount;

        public Revert(IBankAccount bankAccount)
        {
            _bankAccount = bankAccount;
        }


        public decimal Execute()
        {
            return 0;
        }

        public void Execute(decimal transactionNumber)
        {
            
        }

        public void Execute(int transactionNumber)
        {
            _bankAccount.Revert(transactionNumber);
        }
    }
}
