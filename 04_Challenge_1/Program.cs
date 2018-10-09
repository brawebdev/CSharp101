using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository repo = new CustomerRepository();

            Console.WriteLine("Enter Customer ID:");
            var newID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            var newName = Console.ReadLine();

            Console.WriteLine("Enter Customer Age:");
            var newAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer's Years of Service:");
            var newYears = int.Parse(Console.ReadLine());

            Customer newCustomer = new Customer()
            {
                ID = newID,
                LastName = newName,
                Age = newAge,
                YearsOfService = newYears
            };

            repo.AddCustomerToList(newCustomer);
            Console.WriteLine(repo.GetMessage(newCustomer));

            Console.ReadKey();
        }
    }
}
