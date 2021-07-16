using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "kirk";
            musteri1.LastName = "Clark";
            musteri1.NationalIdentity = "111111";
            musteri1.Mail = "seda@hotmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.FirstName = "Rob";
            musteri2.LastName = "Campbell";
            musteri2.NationalIdentity = "222222222";
            musteri2.Mail = "Campbell@hotmail.com";

            Musteri[] musteriler = new Musteri[] 

            {
                musteri1,
                musteri2
            
            };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.AddCustomer(musteri1);
            musteriManager.AddCustomer(musteri2);
            musteriManager.List(musteriler);
            
              

        }
    }
}
