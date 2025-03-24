namespace ZavodNamespace
{
    public class Welder : Worker
    {
        public Welder(string name) : base(name) { }

        public override void DoWork()
        {
            Console.WriteLine($"{Name} выполняет работу сварщика.");
        }
    }
}
