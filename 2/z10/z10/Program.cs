using System.Text.RegularExpressions;

class Task10
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        bool answer = IsRussian(input);

        if (answer)
        {
            Console.WriteLine("Строка содержит русские буквы.");
        }
        else
        {
            Console.WriteLine("Строка не содержит русских букв.");
        }
    }

    public static bool IsRussian(string input)
    {
        Regex regex = new Regex("[А-Яа-я]");
        return regex.IsMatch(input);
    }
}
