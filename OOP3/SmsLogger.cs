using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class SmsLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("sms yollandı");
        }
    }
}
