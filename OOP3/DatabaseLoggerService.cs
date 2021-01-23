using System;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı!");
        }
    }
}