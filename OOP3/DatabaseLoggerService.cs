using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged with Database");
        }
    }
}
