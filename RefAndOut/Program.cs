using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {


            var isim1 = "seda";
            var isim2 = "eda";


            
            var sonucIsımler = isimler(isim1 , isim2);
            Console.WriteLine(sonucIsımler);
            Console.WriteLine(isim1);

        }

        static string isimler(string isim1 , string isim2)
        {
            isim1 = "selin";
            return isim1 + " " + isim2;
        }
        
    }
}
