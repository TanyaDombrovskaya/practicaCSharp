namespace SMNS
{
    public class ServerMonitor
    {
        private readonly List<ISystemObserver> _observers = new List<ISystemObserver>();

        public void AddObserver(ISystemObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"Подписчик {observer.GetType().Name} добавлен.");
        }

        public void RemoveObserver(ISystemObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"Подписчик {observer.GetType().Name} удалён.");
        }

        public void NotifyObservers(string serverName, string message)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(serverName, message);
            }
        }

        public void CheckServer(string serverName, int cpuLoad)
        {
            if (cpuLoad > 80)
            {
                NotifyObservers(serverName, "Сервер перегружен! Необходима проверка.");
            }
            else
            {
                Console.WriteLine($"Сервер '{serverName}' работает нормально (нагрузка: {cpuLoad}%).");
            }
        }
    }
}
