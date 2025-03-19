using System.Text;

class Task9
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();


        StringBuilder sb = new StringBuilder(input);

        string result = sb.ToString();

        Console.Write("Cтрока: ");
        Console.WriteLine(result);
    }
}
