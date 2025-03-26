using System.Text.Json;

namespace Serializer
{
    public interface ISerializer<T>
    {
        string Serialize(T item);  
        T Deserialize(string data);
    }

    public class JsonSerializer<T> : ISerializer<T>
    {
        public string Serialize(T item)
        {
            return JsonSerializer.Serialize(item);
        }

        public T Deserialize(string data)
        {
            return JsonSerializer.Deserialize<T>(data);
        }
    }

    public class SerializerManager<T>
    {
        private readonly ISerializer<T> _serializer;

        public SerializerManager(ISerializer<T> serializer)
        {
            _serializer = serializer;
        }

        public void SaveToFile(T item, string filename)
        {
            string serializedData = _serializer.Serialize(item);
            File.WriteAllText(filename, serializedData);
            Console.WriteLine($"Объект сохранён в файл {filename}");
        }

        public T LoadFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                string serializedData = File.ReadAllText(filename);
                return _serializer.Deserialize(serializedData);
            }
            else
            {
                throw new FileNotFoundException($"Файл {filename} не найден.");
            }
        }
    }
}
