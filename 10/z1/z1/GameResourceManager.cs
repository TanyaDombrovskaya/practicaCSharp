namespace GRMNS
{
    public class GameResourceManager
    {
        private static GameResourceManager _instance;
        private static readonly object _lock = new object();

        private readonly Dictionary<string, object> _resources;
        private GameResourceManager() 
        {
            _resources = new Dictionary<string, object>();
        }

        public static GameResourceManager Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new GameResourceManager();
                }
            }
        }

        public void LoadResource(string name)
        {
            if (!_resources.ContainsKey(name))
            {
                object resource = $"Ресурс: {name}";
                _resources[name] = resource;
                Console.WriteLine($"Ресурс '{name}' загружен.");
            }
            else
            {
                Console.WriteLine($"Ресурс '{name}' загружен ранее.");
            }
        }

        public object GetResource(string name)
        {
            _resources.TryGetValue(name, out object resource);
            return resource;
        }
    }
}