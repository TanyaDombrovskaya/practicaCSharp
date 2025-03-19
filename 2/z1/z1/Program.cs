using MassNamespace;

class Task1
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int count = Convert.ToInt32 (Console.ReadLine());

        int[] A = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите {i + 1} элемент: ");
            A[i] = Convert.ToInt32 (Console.ReadLine());
        }

        Mass array = new(A);

        int countOfNegative = array.CountOfNegativeElements();

        Console.WriteLine($"Количество отрицательных элементов: {countOfNegative}");
    }
}