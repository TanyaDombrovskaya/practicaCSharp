namespace CSNS
{
    public class InMemoryCache : ICacheStrategy
    {
        private readonly Dictionary<string, object> _cache = new Dictionary<string, object>();

        public void Cache(string key, object value)
        {
            _cache[key] = value;
            Console.WriteLine($"[InMemoryCache] Кешировано: {key}");
        }

        public object Retrieve(string key)
        {
            _cache.TryGetValue(key, out var value);
            Console.WriteLine($"[InMemoryCache] Получено: {key}");
            return value;
        }
    }

}
