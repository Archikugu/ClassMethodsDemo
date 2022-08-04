using System;

namespace ClassMethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerName = "Gokhan";
            customer1.CustomerSurname = "Gok";
            customer1.AccountNumber = 123456789;
            customer1.Balance = 1528.00;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerName = "Engin";
            customer2.CustomerSurname = "Demirog";
            customer2.AccountNumber = 12345;
            customer2.Balance = 25045.89;

            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customers in the system " + " " + customer.CustomerName + " " + customer.CustomerSurname + "\n");
            }

            Console.WriteLine("-----------CustomerManager----------- \n");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            Console.WriteLine();
            customerManager.Delete(customer2);
            Console.WriteLine();
            customerManager.Update(customer1);
            Console.WriteLine();
            customerManager.BalanceUpdade(customer1);

        }
    }
}
