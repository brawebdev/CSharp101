using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Queue_Challenge
{
    public class Client
    {
        public string FullName { get; set; }
        public string Issue { get; set; }

        public Client(string name, string issue)
        {
            FullName = name;
            Issue = issue;
        }
    }
}
