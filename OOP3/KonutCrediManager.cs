using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}