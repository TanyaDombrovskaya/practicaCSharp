class Task3
{
    static void Main()
    {
        Console.Write("Введите количество элементов: ");
        int count = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[count];

        Random random = new();

        for (int i = 0; i < count; i++)
        {
            array[i] = random.Next(1, 25);
        }

        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]} ");
        }

        int min = FindMin(array, 0 , array.Length - 1);
        Console.WriteLine($"\nМинимальный элемент: {min}");
    }

    static int FindMin(int[] array, int start, int end)
    {
        if (start == end)
        {
            return array[start];
        }
        int mid = (start + end) / 2;

        int leftMin = FindMin(array, start, mid);
        int rightMin = FindMin(array, mid + 1, end);

        return Math.Min(leftMin, rightMin);
    }
}