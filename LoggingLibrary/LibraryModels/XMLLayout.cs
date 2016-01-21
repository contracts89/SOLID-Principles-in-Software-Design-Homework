using System;
using LoggingLibrary.Contratcs;

namespace LoggingLibrary.LibraryModels
{
    public class XmlLayout : ILayout
    {
        private string dateFormated = DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt").Replace('.','/');
        
        private const string LayoutFormat = "<log>\n    <date>{0}</date>\n    <level>{1}</level>\n" +
                                            "    <message>{2}</message>\n</log>";

        public string Format(string message, ReportLevel reportLevel, DateTime date)
        {
            return string.Format(LayoutFormat, this.dateFormated, reportLevel, message);
        }
    }
}
