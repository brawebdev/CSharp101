using Design_Pattern_Command_2.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_2.Invoker
{
    public class BankAccountInvoker
    {
        ICommand _add, _subtract, _get, _revert;

        public BankAccountInvoker(ICommand add, ICommand subtract, ICommand get, ICommand revert)
        {
            _add = add;
            _subtract = subtract;
            _get = get;
            _revert = revert;
        }

        public void Add(decimal money)
        {
            _add.Execute(money);
        }

        public void Subtract(decimal money)
        {
            _subtract.Execute(money);
        }

        public void Revert(int transactionNumber)
        {
            _revert.Execute(transactionNumber);
        }

        public decimal Get()
        {
           return _get.Execute();
        }
    }
}
