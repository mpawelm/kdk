using Logger.LogType;

namespace Logger
{
    public class Logger
    {
        private readonly ILogger _logger;

        public Logger()
        {
            _logger = new ConsoleLogger();
        }

        public Logger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(LogLevel level, string message)
        {
            _logger.Log(level, message);
        }
    }
}