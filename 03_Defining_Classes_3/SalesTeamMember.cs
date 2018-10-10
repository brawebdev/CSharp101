using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_3
{
    public class SalesTeamMember
    {
        public SalesTeamMember(string lastName, decimal monthlySales)
        {
            LastName = lastName;
            MonthlySales = monthlySales;
        }

        public string LastName { get; set; }
        public decimal MonthlySales { get; set; }
    }
}
