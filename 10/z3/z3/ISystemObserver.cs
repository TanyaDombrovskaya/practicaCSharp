namespace SMNS
{
    public interface ISystemObserver
    {
        void Notify(string serverName, string message);
    }

}
