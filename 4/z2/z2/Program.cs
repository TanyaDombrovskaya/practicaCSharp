class Task2
{
    static void Main()
    {
        Console.Write("A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.Write("C: ");
        double C = Convert.ToDouble(Console.ReadLine());

        Console.Write("D: ");
        double D = Convert.ToInt32(Console.ReadLine());

        Swap(ref A, ref B);
        Swap(ref C, ref D);
        Swap(ref B, ref C);

        Console.WriteLine($"A: {A}, B: {B}, C: {C}, D: {D}");
    }

    static void Swap(ref double x, ref double y)
    {
        double temp = x;
        x = y; 
        y = temp;
    }
}