class Task10
{
    static void Main()
    {
        for (int i = 10; i <= 99; i++)
        {
            int num1 = i / 10;
            int num2 = i % 10;

            if (i == (num1 * num2 * 3))
            {
                Console.WriteLine(i);
            }
        }
    }
}