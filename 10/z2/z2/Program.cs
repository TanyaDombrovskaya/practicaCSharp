using CSNS;

class Task2
{
    static void Main()
    {
        var cacheManager = new CacheManager();

        cacheManager.SetCacheStrategy(new InMemoryCache());
        cacheManager.Cache("item1", "value1");
        Console.WriteLine(cacheManager.Retrieve("item1"));

        cacheManager.SetCacheStrategy(new DistributedCache());
        cacheManager.Cache("item2", "value2");
        Console.WriteLine(cacheManager.Retrieve("item2"));

        cacheManager.SetCacheStrategy(new NoCache());
        cacheManager.Cache("item3", "value3");
        Console.WriteLine(cacheManager.Retrieve("item3"));
    }
}