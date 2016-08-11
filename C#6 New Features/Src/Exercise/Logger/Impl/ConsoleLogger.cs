using Exercise.Common;
using Exercise.Logger.Strategy;
using static Exercise.Common.Constants;
using static Exercise.Common.LoggerType;
using static System.Console;

namespace Exercise.Logger.Impl
{
    public class ConsoleLogger : ILogger
    {
        public LoggerType Type => Console;

        public void Info(LogMessage message) => WriteLine($"{LevelInfo.Info} {message.Message}");

        public void Error(LogMessage message) => WriteLine($"{LevelInfo.Error} {message}");

        public void Warning(LogMessage message) => WriteLine($"{LevelInfo.Warning} {message.Message}");

        public void Fatal(LogMessage message) => WriteLine($"{LevelInfo.Fatal} {message}");

        public void Trace(LogMessage message) => WriteLine($"{LevelInfo.Trace} {message.Message}");
    }
}
