class Task7
{
    static void Main()
    {
        Console.Write("Введите строку:");
        string input = Console.ReadLine();

        int length = LongestSubstring(input);
        Console.WriteLine($"Длина самой длинной подстроки без повторяющихся символов: {length}");
    }

    public static int LongestSubstring(string input)
    {
        Dictionary<char, int> symbolsIndex = new Dictionary<char, int>();
        int maxLength = 0;
        int start = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char symbol = input[i];

            if (symbolsIndex.ContainsKey(symbol) && symbolsIndex[symbol] >= start)
            {
                start = symbolsIndex[symbol] + 1;
            }

            symbolsIndex[symbol] = i;
            maxLength = Math.Max(maxLength, i - start + 1);
        }

        return maxLength;
    }
}
