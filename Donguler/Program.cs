using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için temel kurs";

            //array -- dizi
            string[] kurslar = new string[] { "Yazılım Geliştirme Yetiştirme Kampı" , "Programlamaya Başlangıç için temel kurs" , "Java","Python","C#"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("---------------------------2");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
