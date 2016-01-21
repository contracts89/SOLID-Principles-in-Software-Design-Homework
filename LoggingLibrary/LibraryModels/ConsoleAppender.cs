using System;
using LoggingLibrary.Contratcs;

namespace LoggingLibrary.LibraryModels
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void Append(string message, ReportLevel reportLevel, DateTime date)
        {
            if (this.Threshold <= reportLevel)
            {
                var formattedMessager = this.Layout.Format(message, reportLevel, date);
                Console.WriteLine(formattedMessager);
            }
            
        }
    }
}
