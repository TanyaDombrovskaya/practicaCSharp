using MatrixNamespace;

class Task4
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Matrix matrix1 = new(matrix, rows, cols);

        matrix1.Create();
        matrix1.Show();

        bool answer = matrix1.Answer();

        if (answer == true) Console.WriteLine($"Сумма первой строки больше: {matrix1.SumOfFirstRow()}");
        else Console.WriteLine($"Сумма предпоследней строки больше: {matrix1.SumOfReLastRow()}");
    }
}