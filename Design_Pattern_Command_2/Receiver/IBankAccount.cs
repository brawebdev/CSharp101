using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_2.Receiver
{
    interface IBankAccount
    {
        void Add(decimal money);
        void Subtract(decimal money);
        void Revert(int transactionNumber);
        decimal Get();
    }
}
