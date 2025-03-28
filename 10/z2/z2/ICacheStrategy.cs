namespace CSNS
{
    public interface ICacheStrategy
    {
        void Cache(string key, object value);
        object Retrieve(string key);
    }
}
