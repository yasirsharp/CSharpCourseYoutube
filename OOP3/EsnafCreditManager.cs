﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafCreditManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
