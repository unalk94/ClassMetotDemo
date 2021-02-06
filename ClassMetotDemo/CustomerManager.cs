using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine(customer.CustomerName  +  "Customer Added Succesfully");
        }
        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.CustomerName +  "Customer Removed Succesfully");
        }

        public void CustomerUpdate(Customer customer)
        {
            Console.WriteLine(customer.CustomerName +  "Customer Updated Succesfully");
        }

        public void List(Customer[] customers)
        {
            foreach (var Customer in customers)
            {
                Console.WriteLine(customers);
            }
        }

    }   


}
