namespace ZavodNamespace
{
    public class Assebler : Worker
    {
        public Assebler(string name) : base(name) { }

        public override void DoWork()
        {
            Console.WriteLine($"{Name} выполняет работу сборщика.");
        }
    }
}
