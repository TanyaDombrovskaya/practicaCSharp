namespace ManagerNamspace
{
    public class UserLoginManager
    {
        public event EventHandler UserLoggedIn;

        public void Login(string username)
        {
            Console.WriteLine($"{username} вошел в систему.");
            OnUserLoggedIn();
        }

        protected virtual void OnUserLoggedIn()
        {
            UserLoggedIn?.Invoke(this, EventArgs.Empty);
        }
    }
}
