using LogNamespace;

class Task4
{
    static void Main()
    {
        Logger logger = new Logger();

        IErrorLoger errorLogger = logger;
        errorLogger.Log("This is an error message.");

        IEventLogger eventLogger = logger;
        eventLogger.Log("This is an event message.");
    }
}