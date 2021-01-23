using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggersService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms ile loglandı!");
        }
    }
}
