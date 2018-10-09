using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge_1
{
    class CustomerRepository
    {
        private List<Customer> _customerList = new List<Customer>();

        public void AddCustomerToList(Customer customer)
        {
            _customerList.Add(customer);
        }

        public List<Customer> GetList()
        {
            return _customerList;
        }

    }
}
