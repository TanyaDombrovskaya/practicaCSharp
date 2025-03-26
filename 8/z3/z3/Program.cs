using Serializer;

class Task3
{
    static void Main(string[] args)
    {
        JsonSerializer<Person> jsonSerializer = new JsonSerializer<Person>();
        SerializerManager<Person> serializerManager = new SerializerManager<Person>(jsonSerializer);

        Person person = new Person { Name = "John Doe", Age = 30 };

        string filename = "person.json";
        serializerManager.SaveToFile(person, filename);

        try
        {
            Person loadedPerson = serializerManager.LoadFromFile(filename);
            Console.WriteLine($"Загруженный объект: {loadedPerson}");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
