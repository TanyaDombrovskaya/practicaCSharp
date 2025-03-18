class Task6
{
    static void Main()
    {
        int month = 0;

        while (month < 1 || month > 12)
        {
            Console.Write("Введите порядковый номер месяца: ");
            month = Convert.ToInt32(Console.ReadLine());
        }

        switch (month)
        {
            case 1:
                Console.WriteLine("11");
                break;
            case 2:
                Console.WriteLine("10");
                break;
            case 3:
                Console.WriteLine("9");
                break;
            case 4:
                Console.WriteLine("8");
                break;
            case 5:
                Console.WriteLine("7");
                break;
            case 6:
                Console.WriteLine("6");
                break;
            case 7:
                Console.WriteLine("5");
                break;
            case 8:
                Console.WriteLine("4");
                break;
            case 9:
                Console.WriteLine("3");
                break;
            case 10:
                Console.WriteLine("2");
                break;
            case 11:
                Console.WriteLine("1");
                break;
            case 12:
                Console.WriteLine("0");
                break;

        }
    }
}