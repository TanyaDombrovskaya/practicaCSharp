class Task6 
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();


        string number = IsDigit(input);

        if (number != null)
        {
            Console.WriteLine($"Первое слово, состоящее только из цифр: {number}");
        }
        else
        {
            Console.WriteLine("В строке нет слов, состоящих только из цифр.");
        }

    }

    public static string IsDigit(string input)
    {
        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            bool isNumber = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsDigit(word[i]))
                {
                    isNumber = false;
                }
            }

            if (isNumber)
            {
                return word;
                break;
            }
        }

        return null;
    }

}
