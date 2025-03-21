class Task4
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string line = Console.ReadLine();

        string result = FirstLetters(line);
        Console.WriteLine($"Первые буквы слов: {result}");
    }

    static string FirstLetters(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
        return string.Empty;
        }

        string result = "";

        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            result += word[0];
        }

        return result;
    }
}