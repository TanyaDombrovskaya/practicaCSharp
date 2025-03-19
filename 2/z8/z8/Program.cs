using System;
using System.Collections.Generic;

class Task8
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        Console.Write("Введите количество слов для замены: ");
        int count = Convert.ToInt32(Console.ReadLine());

        List<string> words = new List<string>();
        Console.WriteLine("Введите слова для замены: ");
        for (int i = 0; i < count; i++)
        {
            words.Add(Console.ReadLine());
        }

        string result = ReplaceWords(input, words);

        Console.Write("Результат: ");
        Console.WriteLine(result);
    }

    public static string ReplaceWords(string input, List<string> words)
    {
        foreach (string word in words)
        {
            input = input.Replace(word, "***");
        }

        return input;
    }
}
