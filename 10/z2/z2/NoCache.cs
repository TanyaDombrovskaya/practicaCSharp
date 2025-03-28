namespace CSNS
{
    public class NoCache : ICacheStrategy
    {
        public void Cache(string key, object value)
        {
            Console.WriteLine($"[NoCache] Кеширование отключено.");
        }

        public object Retrieve(string key)
        {
            Console.WriteLine($"[NoCache] Получение данных без кеширования.");
            return null;
        }
    }
}
