using Bogus;
using System;

namespace PersonNamespace
{
    static class ArrayUtils
    {
        private static Random random = new Random();

        public static Person[] Generate(int count)
        { 
            var faker = new Faker<Person>()
                .RuleFor(p => p._name, f => f.Name.FirstName())
                .RuleFor(p => p._age, f => f.Random.Int(18, 60));

            return faker.Generate(count).ToArray();
        }

        public static void Show(Person[] persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine($"{person._name} - {person._age}");
            }
        }

        public static void Sort(Person[] persons)
        {
            Array.Sort(persons, (p1, p2) => p1._age.CompareTo(p2._age));
        }

        public static Person[] Filter(Person[] persons, int age)
        {
            return Array.FindAll(persons, p => p._age == age);
        }

        public static double Statics(Person[] persons)
        {
            if (persons.Length == 0) return 0;

            int average = 0;
            foreach (var person in persons)
            {
                average += person._age;
            }
            return (double)average / persons.Length;
        }

        public static Person[] ShuffleArray(Person[] persons)
        {
            for (int i = persons.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                var temp = persons[i];
                persons[i] = persons[j];
                persons[j] = temp;
            }

            return persons;
        }
    }
}
