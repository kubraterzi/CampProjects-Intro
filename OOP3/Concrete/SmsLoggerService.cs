using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged with SMS");
        }
    }
}
