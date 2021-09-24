using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -- tip güvenliği
            //Do Not Repeat Yourself -- Kendini Tekrarlama
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Sisteme Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
