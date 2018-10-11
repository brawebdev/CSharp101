using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_1
{
    public class Customer
    {
        //public string FirstName { get; set; }

        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }


        public string LastName { get; set; }
        public int Age { get; set; }
        public string Question { get; set; }
    }
}
