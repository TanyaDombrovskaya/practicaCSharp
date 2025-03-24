namespace BatteryNamespace
{
    public delegate void BatteryHadler(object sender, EventArgs e);

    public class BatteryMonitor
    {
        public event BatteryHadler BatteryLow;

        private int _batteryLevel;

        public int BatteryLevel
        {
            get => _batteryLevel;
            set
            {
                _batteryLevel = value;

                if (_batteryLevel < 20) 
                {
                    OnBatteryLow(); 
                }
            }
        }

        protected virtual void OnBatteryLow()
        {
            BatteryLow?.Invoke(this, EventArgs.Empty);
        }
    }

}
