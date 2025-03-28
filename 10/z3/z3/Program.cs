using SMNS;

class Task3
{
    static void Main()
    {
        ServerMonitor serverMonitor = new ServerMonitor();

        Admin admin = new Admin();
        DevOps devOps = new DevOps();

        serverMonitor.AddObserver(admin);
        serverMonitor.AddObserver(devOps);

        serverMonitor.CheckServer("Server1", 60); 
        serverMonitor.CheckServer("Server2", 90); 

        serverMonitor.RemoveObserver(admin);

        serverMonitor.CheckServer("Server3", 85); 
    }
}