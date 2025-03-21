using CookNamespace;

class Task5
{
    static void Main()
    {
        Food pizza = new Pizza();
        Food pasta = new Pasta();

        pizza.Cook();
        pasta.Cook();

        pizza.Serve();
        pasta.Serve();
    }
}