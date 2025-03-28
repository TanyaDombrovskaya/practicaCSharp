namespace CSNS
{
    public class DistributedCache : ICacheStrategy
    {
        private readonly Dictionary<string, object> _cache = new Dictionary<string, object>();

        public void Cache(string key, object value)
        {
            _cache[key] = value;
            Console.WriteLine($"[DistributedCache] Кешировано: {key}");
        }

        public object Retrieve(string key)
        {
            _cache.TryGetValue(key, out var value);
            Console.WriteLine($"[DistributedCache] Получено: {key}");
            return value;
        }
    }

}
