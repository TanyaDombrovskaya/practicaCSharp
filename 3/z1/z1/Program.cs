using ANamespace;

class Task1
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = Convert.ToInt32 (Console.ReadLine());

        Console.Write("Введите b: ");
        int b = Convert.ToInt32 (Console.ReadLine());

        A c = new(a, b);
        double result1 = c.Func1();
        double result2 = c.Func2();

        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
}