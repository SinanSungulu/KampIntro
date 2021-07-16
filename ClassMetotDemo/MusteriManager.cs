using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void AddCustomer(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : "+ musteri.FirstName, musteri.LastName+ "(" + musteri.Id + ")");
        }
        public void RemoveCustomer(Musteri musteri)
        {
            Console.WriteLine("Müşteri kaldırıldı : "+musteri.FirstName , musteri.LastName+ "("+musteri.Id+")");
        }
        public void List(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler ...");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.FirstName);
            }

        }


    }
}
