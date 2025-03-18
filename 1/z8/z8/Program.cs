class Task8
{
    static void Main()
    {
        int price = 0;

        while (price < 1 || price > 100)
        {
            Console.Write("Введите стоимость за 1 кг: ");
            price = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Стоимость {i} кг конфет {IsPrice(price, i)} рублей");
        }
    }

    public static int IsPrice(int price, int count)
    {
        return price * count;
    }
}