using DIP.PoorExample;
using System;
 
namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            //PoorExample();
            GoodExample();
            Console.ReadKey();
        }
        static void PoorExample()
        {
            LogWriter logger = new LogWriter();
            logger.WriteLogToMysql();
            logger.WriteLogToOracle();
        }
        static void GoodExample()
        {
            GoodExample.LogWriter mysqlLogWriter = new GoodExample.LogWriter(new GoodExample.MysqlLogger());
            mysqlLogWriter.WriteLog();

            GoodExample.LogWriter oracleLogWriter = new GoodExample.LogWriter(new GoodExample.OracleLogger());
            oracleLogWriter.WriteLog();
        }
    }
}
