using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediMAnager konutKrediMAnager = new KonutKrediMAnager();

            BasvuruManager basvuruManager = new BasvuruManager();


            basvuruManager.BasvuruYap(konutKrediMAnager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager, tasitKrediManager, konutKrediMAnager };
            //basvuruManager.KrediOnBilgirendirmesiYap(krediler);
        }
    }
}
