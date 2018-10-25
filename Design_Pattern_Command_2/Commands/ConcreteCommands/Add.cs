using Design_Pattern_Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_2.Commands.ConcreteCommands
{
    class Add : ICommand
    {
        private IBankAccount _bankAccount;

        public Add(IBankAccount bankAccount)
        {
            _bankAccount = bankAccount;
        }
        public void Execute(decimal money)
        {
            _bankAccount.Add(money);
        }

        public decimal Execute()
        {
            return 0;
        }
    }
}
