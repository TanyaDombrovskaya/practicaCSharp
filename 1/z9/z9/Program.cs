class Task9
{
    static void Main()
    {
        int A = 0;
        double B = Math.PI / 2;
        int M = 20;

        double H = (B - A) / 2;

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H;
            double y = Math.Sin(x) - Math.Cos(x);
            Console.WriteLine($"x = {x:F4}, y = {y:F4}");
        }
    }
}