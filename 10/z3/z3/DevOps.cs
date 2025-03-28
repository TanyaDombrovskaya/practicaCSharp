    namespace SMNS
{
    public class DevOps : ISystemObserver
    {
        public void Notify(string serverName, string message)
        {
            Console.WriteLine($"[DevOps] Уведомление о сервере '{serverName}': {message}");
        }
    }
}
