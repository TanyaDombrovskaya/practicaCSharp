using MassNamespace;

class Task2
{
    static void Main()
    {
        int count = 99;
        int[] array = new int[count];

        Mass massiv = new(array);

        massiv.Create();

        Console.WriteLine("Исходный массив: ");
        massiv.Show();
        Console.WriteLine("\n");

        Console.WriteLine("Отсортированный массив: ");
        massiv.Sort();
        massiv.Show();
        Console.WriteLine("\n");

        Console.WriteLine("Массив без максимального и минималльного элемента: ");
        massiv.RemoveMax();
        massiv.RemoveMin();
        massiv.Show();
        Console.WriteLine("\n");

        Console.Write("Введите число для поиска: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int index = massiv.BinarySearch(number);
        Console.WriteLine($"Число {number} найдено в  индексе {index}");
    }
}