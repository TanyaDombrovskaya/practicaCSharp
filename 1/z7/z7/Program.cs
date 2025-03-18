class Task7
{
    static void Main()
    {
        Console.Write("Введите курс перевода: ");
        double kurs = Convert.ToDouble(Console.ReadLine());

        for (int countOfDollars = 5; countOfDollars <= 500; countOfDollars += 5) {
            double byn = Translate(kurs, countOfDollars);
            Console.WriteLine($"{countOfDollars} долларов = {byn} BYN.");
        }
    }

    public static double Translate(double kurs, int countOfDollars)
    {
        return kurs * countOfDollars;
    }
}