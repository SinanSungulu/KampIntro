using System;

namespace Working
{
    class Program
    {
        static void Main(string[] args)
        {
            var isim1 = "seda";
            var isim2 = "selin";
            var sonucIsım = isim(isim1,isim2);

            Console.WriteLine(sonucIsım);
            Console.WriteLine(isim1);
        }

        static  string isim (string ısım1 , string ısım2)
        {
            ısım1 = "asd ";
            return ısım1 + " " + ısım2;
        }      
    }
}
//ref keyword 
//out keyword
