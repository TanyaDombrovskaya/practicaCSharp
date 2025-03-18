using CircleNamespace;

class Task1 {
    static void Main() {
        Console.Write("Введите радиус окружноcти: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new(radius);

        double length = circle.GetLength();
        double square = circle.GetSquare();

        Console.WriteLine($"Длина окружности с радиусом {radius} = {length:F2}");
        Console.WriteLine($"Площадь круга с радиусом {radius} = {square:F2}");
    }
}