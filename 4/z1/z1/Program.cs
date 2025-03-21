class Task1
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string line = Console.ReadLine();

        int count = CountOfWords(line);
        Console.WriteLine($"Количество слов в строке: {count}");
    }

    static int CountOfWords(string line)
    { 
        string[] words = line.Split(' ');

        int count = words.Length;

        return count;
    }
}