using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_1
{
    public class Employee
    {
        public Employee() { }

        public Employee(string lastName, int age, int hours)
        {
            EmployeeLastName = lastName;
            EmployeeAge = age;
            HoursWorked = hours;
        }
        public int EmployeeID { get; set; }
        public string EmployeeLastName { get; set; }
        public int EmployeeAge { get; set; }
        public int HoursWorked { get; set; }
    }
}
