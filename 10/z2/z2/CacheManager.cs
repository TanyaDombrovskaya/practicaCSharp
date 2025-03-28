namespace CSNS
{
    public class CacheManager
    {
        private ICacheStrategy _cacheStrategy;

        public void SetCacheStrategy(ICacheStrategy strategy)
        {
            _cacheStrategy = strategy;
            Console.WriteLine($"[CacheManager] Стратегия установлена: {strategy.GetType().Name}");
        }

        public void Cache(string key, object value)
        {
            _cacheStrategy.Cache(key, value);
        }

        public object Retrieve(string key)
        {
            return _cacheStrategy.Retrieve(key);
        }
    }

}
