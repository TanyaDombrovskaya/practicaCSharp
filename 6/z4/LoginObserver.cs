namespace ManagerNamspace
{
    public class LoginObserver
    {
        private readonly UserLoginManager _loginManager;

        public LoginObserver(UserLoginManager loginManager)
        {
            _loginManager = loginManager;
        }

        public void Subscribe(SecuritySystem securitySystem, NotificationService notificationService)
        {
            _loginManager.UserLoggedIn += securitySystem.CheckAccess;
            _loginManager.UserLoggedIn += notificationService.SendNotification;
        }
    }
}
