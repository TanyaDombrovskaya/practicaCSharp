namespace CookNamespace
{
    abstract class Food
    {
        public abstract void Cook();

        public virtual void Serve() 
        {
            Console.WriteLine("The dish is served");
        }
    }

    class Pizza : Food
    {
        public override void Cook()
        {
            Console.WriteLine("Pizza is cooking.");
        }

        public override void Serve()
        {
            Console.WriteLine("The pizza is served.");
        }
    }

    class Pasta : Food
    {
        public override void Cook()
        {
            Console.WriteLine("Pasta is cooking.");
        }

        public override void Serve()
        {
            Console.WriteLine("The pasta is served.");
        }
    }
}
