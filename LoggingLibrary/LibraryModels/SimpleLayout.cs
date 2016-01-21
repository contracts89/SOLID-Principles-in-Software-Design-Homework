using System;
using LoggingLibrary.Contratcs;

namespace LoggingLibrary.LibraryModels
{
    public class SimpleLayout : ILayout
    {
        private const string LayoutFormat = "{0} - {1} - {2}";

        public string Format(string message, ReportLevel reportLevel, DateTime date)
        {
            return string.Format(LayoutFormat, date, reportLevel, message);
        }
    }
}
