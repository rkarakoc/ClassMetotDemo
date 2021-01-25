using Stripe;
using System;
using System.Collections.Generic;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Customers customer1 = new Customers();
            customer1.Id = 1;
            customer1.TcNo = "12345678990";
            customer1.FirstName = "Rıza";
            customer1.LastName = "Karakoç";
            customer1.PhoneNumber = "5511234567";
            customer1.Mail = "rizakarakoc@karakoc.com";
            customer1.City = "Balıkesir";

            Customers customer2 = new Customers();
            customer2.Id = 2;
            customer2.TcNo = "12345678992";
            customer2.FirstName = "Pınar";
            customer2.LastName = "Karakoç";
            customer2.PhoneNumber = "5551234567";
            customer2.Mail = "pinarkarakoc@karakoc.com";
            customer2.City = "Balıkesir";
            Customers[] customers = new Customers[] { customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            
            customerManager.List(customers);

        }
    }
}
