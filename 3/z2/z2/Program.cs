using PersonNamespace;

class Task2
{
    static void Main()
    {
        Person[] persons = ArrayUtils.Generate(5);

        Console.WriteLine("Сгенерированный массив: ");
        ArrayUtils.Show(persons);
        Console.Write("\n");

        Console.WriteLine("Отсортированный массив: ");
        ArrayUtils.Sort(persons);
        ArrayUtils.Show(persons);
        Console.Write("\n");

        double average = ArrayUtils.Statics(persons);
        Console.WriteLine($"Средний возраст: {average}");
        Console.Write("\n");

        Console.WriteLine("Перемешанный массив: ");
        ArrayUtils.ShuffleArray(persons);
        ArrayUtils.Show(persons);
        Console.Write("\n");

        Console.Write("Введите возраст для фильтрации: ");
        int filterAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Отфильтрованный массив: ");
        Person[] filteredPersons = ArrayUtils.Filter(persons, filterAge);
        ArrayUtils.Show(filteredPersons);
    }
}