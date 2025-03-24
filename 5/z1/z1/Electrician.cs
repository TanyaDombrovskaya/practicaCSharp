using System.Xml.Linq;

namespace ZavodNamespace
{
    public class Electrician :Worker
    {
        public Electrician(string name) : base(name) { }

        public override void DoWork()
        {
            Console.WriteLine($"{Name} выполняет работу электрика.");
        }
    }
}
