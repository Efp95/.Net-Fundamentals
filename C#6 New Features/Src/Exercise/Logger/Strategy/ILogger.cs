using Exercise.Common;

namespace Exercise.Logger.Strategy
{
    public interface ILogger
    {
        LoggerType Type { get; }

        void Info(LogMessage message);
        void Error(LogMessage message);
        void Warning(LogMessage message);
        void Fatal(LogMessage message);
        void Trace(LogMessage message);
    }
}
