namespace DIP.PoorExample
{
    public class LogWriter
    {
        public void WriteLogToOracle()
        {
            OracleLogger oracleLogger = new OracleLogger();
            oracleLogger.WriteLog();
        }

        public void WriteLogToMysql()
        {
            MysqlLogger mysqlLogger = new MysqlLogger();
            mysqlLogger.WriteLog();
        }

    }
}
