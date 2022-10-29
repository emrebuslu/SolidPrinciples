namespace DIP.PoorExample
{
    public class LogWriter
    {
        /* <<< Dependency Inversion Principle VIOLATE */
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
        /* Dependency Inversion Principle VIOLATE >>> */
    }
}
