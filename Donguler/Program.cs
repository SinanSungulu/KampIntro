using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {



            product product1 = new product();
            product product2 = new product();
            product product3 = new product();

            product1.urunAdı = "urun1";
            product2.urunAdı = "urun2";
            product3.urunAdı = "urun3";


            product[] products = new product[] 
            { 
                
                
                product1,
                product2,
                product3
            
            };

            //for
            Console.WriteLine("For");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].urunAdı);
            }



            //foreach
            Console.WriteLine("Foreach");
            foreach (var product in products)
            {
                Console.WriteLine(product.urunAdı);
            }



            //while
            Console.WriteLine("While");
            int  j = 0;

            while (j < products.Length)
            {

                Console.WriteLine(products[j].urunAdı);
                j++;
            }

             

           

        }

    }


    class product {
        public string urunAdı { get; set; }
       
    }



}
