using Design_Pattern_Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_2.Commands.ConcreteCommands
{
    class Subtract : ICommand
    {
        private IBankAccount _bankAccount;

        public Subtract(IBankAccount bankAccount)
        {
            _bankAccount = bankAccount;
        }

        public void Execute(decimal money)
        {
            _bankAccount.Subtract(money);
        }

        public decimal Execute()
        {
            return 0;
        }
    }
}
