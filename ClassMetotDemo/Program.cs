using System;
using System.Collections.Generic;
using System.Text;
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 001;
            customer1.CustomerName = "Ünal";
            customer1.CustomerSurname = "Kamalı";

            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[] { customer1 };
            Console.WriteLine();

            customerManager.Add(customer1);

            customerManager.List(customers); 

            Console.WriteLine();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerId);
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerSurname);
            }

           
        }
    }
}
