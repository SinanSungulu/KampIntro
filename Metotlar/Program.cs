using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 80;
            urun2.Acıklama = "asdasd";

            Urun[] urunler = new Urun[]
            {
                urun1,
                urun2

            };
            

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("---------------");
            }



            SepetManager sepetManager = new SepetManager();


            //encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

           





        }
    }
}


//tekrar tekrar  kullanıla biliriği sağlayan kod bloklarıdır  -DRY - Best practice 
