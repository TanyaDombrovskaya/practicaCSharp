namespace LogNamespace
{
    public class Logger : IErrorLoger, IEventLogger
    {
        void IErrorLoger.Log(string message)
        {
            Console.WriteLine($"Error: {message}");
        }

        void IEventLogger.Log(string message)
        {
            Console.WriteLine($"Event: {message}");
        }
    }
}
