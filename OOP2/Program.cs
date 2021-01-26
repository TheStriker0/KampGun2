using System;

namespace OOP2
{
    class Program
    {
        //SOLID
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Asım";
            musteri1.Soyadi = "Baki";
            musteri1.Id = 44;
            musteri1.TcNo = "44444444444";
            musteri1.MusteriNo = "123456";

            //Tüzel Müşteri

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "654123";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri(); 
            
        }
    }
}
