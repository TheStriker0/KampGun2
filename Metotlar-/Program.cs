using System;

namespace Metotlar_
{
    class Program
    {
        static void Main(string[] args)
        {
            Product elma = new Product();
            elma.Adi = "Elma";
            elma.Fiyati = 15;
            elma.Aciklama = "Amasya Elması";

            Product karpuz = new Product();
            karpuz.Aciklama = "Diyarbakır Karpuzu";
            karpuz.Adi = "Karpuz";
            karpuz.Fiyati = 80;

            Product[] urunler = new Product[] { elma, karpuz };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("-------------Metotlar-----------");
            SepetManeger sepetManeger = new SepetManeger();
            sepetManeger.Ekle(elma);
            sepetManeger.Ekle(karpuz);

            sepetManeger.Ekle2("Armut", "Yeşil Armut", 12);
        }
    }
}
