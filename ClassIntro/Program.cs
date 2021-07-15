using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            kurs kurs1 = new kurs();
            kurs kurs2 = new kurs();
            kurs kurs3 = new kurs();

            kurs1.KursAdı = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 1;

            kurs2.KursAdı = "java";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOranı = 1;

            kurs3.KursAdı = "python";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.IzlenmeOranı = 1;

            kurs[] kurslar = new kurs[]
            {
                kurs1,
                kurs2,
                kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı);
            }
        }
    }

    class kurs
    {

        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }


    }





}
