using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string divider = "------------------------------------";
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Giriş Temelleri Kursu";
            string kurs3 = "Java";
            string kurs4 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);


            //Array = Dizi

            string[] kurslar = new string[] {
                divider,
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Giriş Temelleri Kursu",
                "Java",
                "Python",
                "CSharp"
            };

            for (int i=0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i] + "for döngüsü bitti.");
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs + "foreach döngüsü bitti.");
            }

            Console.WriteLine(divider);
            Console.WriteLine("Sayfa Sonu - FOOTER");

            Console.ReadLine();
        }
    }
}