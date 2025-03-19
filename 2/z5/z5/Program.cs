class Task5
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        int[][] array = new int[rows][];

        Create(array);
        Console.WriteLine("Массив:");
        Show(array);

        bool answer = CheckArray(array, rows);

        Console.WriteLine($"Являются лис троки переставновками? - {answer}");
    }

    static void Create(int[][] array)
    {
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите количество элементов в строке {i + 1}: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            array[i] = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                array[i][j] = random.Next(1, 25);
            }
        }
    }

    public static void Show(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write($"{array[i][j]} ");
            }
            Console.WriteLine();
        }
    }

    public static bool CheckArray(int[][] array, int rows)
    {
        bool answer = false;

        var reference = array[0];
        Array.Sort(reference);

        for (int i = 0; i < rows; i++)
        {
            Array.Sort(array[i]);

            if (reference == array[i]) answer = true;
            else answer = false;
        }

        return answer;
    }
}
