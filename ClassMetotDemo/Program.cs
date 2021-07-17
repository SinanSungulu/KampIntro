using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "kirk";
            customer1.LastName = "Clark";
            customer1.NationalIdentity = "111111";
            customer1.Mail = "clark@hotmail.com";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Rob";
            customer2.LastName = "Campbell";
            customer2.NationalIdentity = "222222222";
            customer2.Mail = "Campbell@hotmail.com";

            Customer[] customers = new Customer[] 

            {
                customer1,
                customer2
            
            };

            CustomerManager musteriManager = new CustomerManager();

            musteriManager.AddCustomer(customer1);
            musteriManager.AddCustomer(customer2);
            musteriManager.List(customers);
            
              

        }
    }
}
