namespace BatteryNamespace
    {
    public class UserNotifier
    {
        public void Notify(object sender, EventArgs e)
        {
            Console.WriteLine("Низкий заряд батареи.");
        }
    }
}
