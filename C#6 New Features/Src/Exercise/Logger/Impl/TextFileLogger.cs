using Exercise.Common;
using Exercise.Logger.Strategy;
using static Exercise.Common.LoggerType;
using static Exercise.Utils.NullValidator;

namespace Exercise.Logger.Impl
{
    public class TextFileLogger : ILogger
    {
        public LoggerType Type => TextFile;

        public void Info(LogMessage message) => Check(message, "m");

        public void Error(LogMessage message) => Check(message, "m");

        public void Warning(LogMessage message) => Check(message, "m");

        public void Fatal(LogMessage message) => Check(message, "m");

        public void Trace(LogMessage message) => Check(message, "m");
    }
}
