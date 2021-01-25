using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class CustomerManager
    {
        
        public void Add(Customers customer)
        {
            Console.WriteLine(customer.Id + "Id nolu müşteri eklendi.");
        }
        public void Update(Customers customer)
        {
            Console.WriteLine(customer.Id + "Id nolu müşteri güncellendi.");
        }
        public void Delete(Customers customer)
        {
            Console.WriteLine(customer.Id + "Id nolu müşteri silindi.");
        }
       
        public void List(Customers[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);

            }
        }
    }
}
