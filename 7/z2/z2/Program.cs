using DeserializerNamespace;

class Task2
{
    static void Main()
    {
        XmlDeserializer deserializer = new XmlDeserializer();
        XmlProcessor processor = new XmlProcessor(deserializer);

        string xml = "<root>root";

        try
        {
            processor.ProcessXml(xml);
        }
        catch (DeserializationException ex)
        {
            Console.WriteLine($"DeserializationException: {ex.Message}");
            Console.WriteLine($"InnerException: {ex.InnerException.Message}");
        }
    }
}
