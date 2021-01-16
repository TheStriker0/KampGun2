using System;

namespace KampGun2
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool SistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("Azalış img");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış");

            }

            else
            {
                Console.WriteLine("Sabit");
            }

            if (SistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
