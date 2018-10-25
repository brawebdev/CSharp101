using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_2.Commands
{
    public interface ICommand
    {
        void Execute(decimal money);
        decimal Execute();
    }
}
