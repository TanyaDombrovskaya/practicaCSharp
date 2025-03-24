using BatteryNamespace;

class Task3
{
    static void Main()
    {
        BatteryMonitor monitor = new();

        PowerSaver saver = new();
        UserNotifier notifier = new();

        monitor.BatteryLow += saver.SaverOn;
        monitor.BatteryLow += notifier.Notify;

        int battery = 15;

        monitor.BatteryLevel = battery;
    }
}