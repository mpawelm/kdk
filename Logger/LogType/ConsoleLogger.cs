using System;

namespace Logger.LogType
{
    public class ConsoleLogger : ILogger
    {
        public void Log(LogLevel level, string message)
        {
            Console.WriteLine("{0}, {1}, {2} : {3}", DateTime.Now, "jakis string", level, message);
        }
    }
}