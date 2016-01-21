using System;

namespace LoggingLibrary.Contratcs
{
    public interface ILayout
    {
        
        string Format(string message, ReportLevel reportLevel, DateTime date);
    }
}
