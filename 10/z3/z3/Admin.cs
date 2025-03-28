namespace SMNS
{
    public class Admin : ISystemObserver
    {
        public void Notify(string serverName, string message)
        {
            Console.WriteLine($"[Admin] Уведомление о сервере '{serverName}': {message}");
        }
    }
}
