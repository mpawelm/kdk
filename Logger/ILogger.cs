namespace Logger
{
    public interface ILogger
    {
        void Log(LogLevel level, string message);
    }
}