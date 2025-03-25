namespace DeserializerNamespace
{
    using System;

    public class DeserializationException : Exception
    {
        public DeserializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class XmlDeserializer
    {
        public void Deserialize(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml) || !xml.StartsWith("<") || !xml.EndsWith(">"))
            {
                throw new InvalidOperationException("Неверный формат XML.");
            }

            Console.WriteLine("XML успешно десериализован.");
        }
    }

    public class XmlProcessor
    {
        private readonly XmlDeserializer _deserializer;

        public XmlProcessor(XmlDeserializer deserializer)
        {
            _deserializer = deserializer;
        }

        public void ProcessXml(string xml)
        {
            try
            {
                _deserializer.Deserialize(xml);
            }
            catch (InvalidOperationException ex)
            {
                throw new DeserializationException("Ошибка при десериализации XML.", ex);
            }
        }
    }
}
