namespace TeamNamespace
{
    public class Footballer : TeamMember, IFootballerPlayer
    {
        public Footballer(string name) : base(name) { }

        public void PlayFootball()
        {
            Console.WriteLine($"{Name} играет в футбол.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Роль: Футболист");
        }
    }
}
