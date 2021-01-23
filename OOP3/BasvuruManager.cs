using System.Collections.Generic;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(ICrediManager crediManager, ILoggerService loggerService)
        {
            //Başvuru Bilgilerini Değerlendirme
            //
            crediManager.Calculate();

            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<ICrediManager> credits)
        {
            foreach (var credi in credits)
            {
                credi.Calculate();
            }
        }
    }
}