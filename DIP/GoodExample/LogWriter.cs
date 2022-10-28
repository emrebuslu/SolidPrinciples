using DIP.GoodExample.Abstraction;

namespace DIP.GoodExample
{
    public class LogWriter
    {
        ILogger logger;
        public LogWriter(ILogger logger)
        {
            this.logger = logger;
        }
        public void WriteLog()
        {
            logger.WriteLog();
        }
    }
}
