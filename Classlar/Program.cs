using System;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.KursEgitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 44;

            Console.WriteLine(kurs1.İzlenmeOrani);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string KursEgitmen { get; set; }

        public int İzlenmeOrani { get; set; }
    }
}
