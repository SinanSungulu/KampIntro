using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi : "+ customer.FirstName, customer.LastName+ "(" + customer.Id + ")");
        }
        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri kaldırıldı : "+customer.FirstName , customer.LastName+ "("+customer.Id+")");
        }
        public void List(Customer[] Customers)
        {
            Console.WriteLine("Müşteriler ...");
            foreach (var musteri in Customers)
            {
                Console.WriteLine(musteri.FirstName);
            }

        }


    }
}
