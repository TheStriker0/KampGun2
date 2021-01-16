using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar_
{
    class SepetManeger
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi : "+ urunAdi);
        }
    }
}
