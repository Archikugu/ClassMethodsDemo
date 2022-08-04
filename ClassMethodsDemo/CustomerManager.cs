using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " : " + "Successfully added to the system");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " " + "Successfully deleted from the system");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " " + "customer information updated");
        }
        public void BalanceUpdade(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.Balance + " " + "Balance updated !!");
        }
    }
}
