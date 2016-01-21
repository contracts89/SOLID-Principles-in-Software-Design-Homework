using LoggingLibrary.Contratcs;
using LoggingLibrary.LibraryModels;

namespace TestLibraryLogger
{
    class Program
    {
        static void Main()
        {
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender =
                 new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));

            //var xmlLayout = new XmlLayout();
            //var consoleAppender = new ConsoleAppender(xmlLayout);
            //var logger = new Logger(consoleAppender);

            //logger.Fatal("mscorlib.dll does not respond");
            //logger.Critical("No connection string found in App.config");

            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);
            //consoleAppender.Threshold = ReportLevel.Error;

            //var logger = new Logger(consoleAppender);

            //logger.Info("Everything seems fine");
            //logger.Warn("Warning: ping is too high - disconnect imminent");
            //logger.Error("Error parsing request");
            //logger.Critical("No connection string found in App.config");
            //logger.Fatal("mscorlib.dll does not respond");
        }
    }
}
