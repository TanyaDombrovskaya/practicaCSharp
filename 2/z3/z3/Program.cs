using MatrixNamespace;

class Task3
{
    static void Main()
    {
        int N = 0;

        while (N <= 0 || N >= 10) {
            Console.Write("Введите размерность матрицы от 1 до 10: ");
            N = Convert.ToInt32(Console.ReadLine());
        }

        int[,] array = new int[N, N];

        Console.Write("Введите первую границу: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите вторую границу: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Matrix matrix = new(array, N,  a, b);

        Console.WriteLine("Исходная матрица:");
        matrix.Create();
        matrix.Show();

        Console.Write("Введите число G: ");
        int G = Convert.ToInt32(Console.ReadLine());

        double average = matrix.Average(G);
        Console.WriteLine($"Среднее арифметическое элементов больших {G}: {average}");

        int k = 0;

        while (k <= 0 || k >= N)
        {
            Console.Write("Введите номер строки: ");
            k = Convert.ToInt32(Console.ReadLine());
        }

        int count = matrix.HonestCount(k);
        Console.WriteLine($"Количество четных элементов в строке {k}: {count}");
    }
}