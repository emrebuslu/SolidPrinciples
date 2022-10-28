using DIP.GoodExample.Abstraction;
using System;

namespace DIP.GoodExample
{
    public class MysqlLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Logger write to mysql db.");
        }
    }
}
