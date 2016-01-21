using System;

namespace LoggingLibrary.Contratcs
{
    public interface IAppender
    {
        ILayout Layout {get; set; }

        ReportLevel Threshold { get; set; }

        void Append(string message, ReportLevel reportLevel, DateTime date);
    }
}
