using System;

namespace Exercise.Logger.Strategy
{
    public class LogMessage
    {
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public DateTime Date { get; } = DateTime.Now;

        public override string ToString()
            => $"-Error: {Exception.Message} -StackTrace: {Exception.StackTrace} -Date: {Date} -Info: {Message}";
    }
}
