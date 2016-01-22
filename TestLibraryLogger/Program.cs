using System;
using LoggingLibrary;
using LoggingLibrary.Contratcs;
using LoggingLibrary.LibraryModels;

namespace TestLibraryLogger
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Test One");
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender =
                 new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));

            Console.WriteLine();

            Console.WriteLine("Test two");
            var xmlLayout = new XmlLayout();
            var consoleAppenderNew = new ConsoleAppender(xmlLayout);
            var loggerNew = new Logger(consoleAppenderNew);

            loggerNew.Fatal("mscorlib.dll does not respond");
            loggerNew.Critical("No connection string found in App.config");

            Console.WriteLine();

            Console.WriteLine("Test three");
            var simpleLayoutTest = new SimpleLayout();
            var consoleAppenderTest = new ConsoleAppender(simpleLayoutTest);
            consoleAppenderTest.Threshold = ReportLevel.Error;

            var loggerTest = new Logger(consoleAppender);

            loggerTest.Info("Everything seems fine");
            loggerTest.Warn("Warning: ping is too high - disconnect imminent");
            loggerTest.Error("Error parsing request");
            loggerTest.Critical("No connection string found in App.config");
            loggerTest.Fatal("mscorlib.dll does not respond");
        }
    }
}
