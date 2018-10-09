using _04_Employee_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Employee_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repo = new EmployeeRepository();

            Console.WriteLine("Enter Employee ID: ");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Employee Age: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary: ");
            var salary = double.Parse(Console.ReadLine());

            Employee newEmployee = new Employee
            {
                EmployeeID = id,
                Name = name,
                Age = age,
                Salary = salary,
            };

            repo.AddEmployeeToList(newEmployee);

            var newList = repo.GetList();
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.EmployeeID + " " + employee.Name + " " + employee.Age + " " + employee.Salary);
            }
        }
    }
}
