using ManagerNamspace;
using System;

class Task4
{
    static void Main()
    {
        UserLoginManager loginManager = new UserLoginManager();

        SecuritySystem securitySystem = new SecuritySystem();
        NotificationService notificationService = new NotificationService();

        LoginObserver observer = new LoginObserver(loginManager);
        observer.Subscribe(securitySystem, notificationService);

        loginManager.Login("user");
    }
}
