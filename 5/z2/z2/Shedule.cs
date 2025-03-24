namespace CinemaNamespace
{
    public class Shedule
    {
        public string[] TimeSlots { get; private set; }

        public Shedule(string[] timeSlots)
        {
            TimeSlots = timeSlots;
        }

        public void ShowSchedule()
        {
            Console.WriteLine("Расписание:");
            foreach (string time in TimeSlots)
            {
                Console.WriteLine($"- {time}");
            }
        }
    }
}
