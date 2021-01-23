using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ihtiyacCrediManager = new IhtiyacCrediManager();
            ICrediManager tasitCrediManager = new TasitCrediManager();
            ICrediManager konutCrediManager = new KonutCrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafCreditManager(), new SmsLoggersService());

            List<ICrediManager> credits = new List<ICrediManager> {ihtiyacCrediManager, tasitCrediManager, konutCrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(credits);


        }
    }
}