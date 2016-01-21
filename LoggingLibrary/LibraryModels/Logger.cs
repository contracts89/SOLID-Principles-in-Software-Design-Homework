using System;
using System.Collections.Generic;
using LoggingLibrary.Contratcs;

namespace LoggingLibrary.LibraryModels
{
    public class Logger : ILogger
    {
        public IList<IAppender> Appenders { get; private set; }

        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public void Info(string message)
        {
            this.Logging(message, ReportLevel.Info);
        }

        public void Warn(string message)
        {
            this.Logging(message, ReportLevel.Warn);
        }

        public void Error(string message)
        {
            this.Logging(message, ReportLevel.Error);
        }

        public void Critical(string message)
        {
            this.Logging(message, ReportLevel.Critical);
        }

        public void Fatal(string message)
        {
            this.Logging(message, ReportLevel.Fatal);
        }

        private void Logging(string message, ReportLevel reportLevel)
        {
            foreach (var appender in this.Appenders)
            {
                var date = DateTime.Now;
                appender.Append(message, reportLevel, date);
            }
        }
    }
}
