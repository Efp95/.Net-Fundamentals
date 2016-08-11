using Exercise.Common;
using Exercise.Logger.Impl;
using Exercise.Logger.Strategy;
using System;
using System.Collections.Generic;

namespace Exercise.Logger
{
    public static class LoggerManager
    {
        private static readonly Dictionary<LoggerType, ILogger> Loggers;

        static LoggerManager()
        {
            Loggers = new Dictionary<LoggerType, ILogger>();

            Loggers.Add(LoggerType.TextFile, new TextFileLogger());
            Loggers.Add(LoggerType.Console, new ConsoleLogger());
        }

        public static ILogger Get(LoggerType type)
        {
            if (Loggers.ContainsKey(type))
            {
                return Loggers[type];
            }

            throw new ArgumentException($"Incorrect value {type} param: {nameof(type)}");
        }
    }
}
