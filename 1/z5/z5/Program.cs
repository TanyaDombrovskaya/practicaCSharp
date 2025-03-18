using TriangleNamespace;

class Task5
{
    static void Main()
    {
        Console.Write("Введите сторону A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите сторону B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите сторону C: ");
        double sideC = Convert.ToDouble(Console.ReadLine());

        Triangle triangle = new(sideA, sideB, sideC);

        bool answer = triangle.IsExists();

        Console.WriteLine($"Существует ли треугольник? - {answer}");
    }
}