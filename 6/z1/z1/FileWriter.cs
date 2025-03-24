namespace FileNamespace
{
    public class FileWriter
    {
        public void WriteFile(string filePath)
        {
            Console.Write("Введите текст для записи в файл:");
            string content = Console.ReadLine();

            File.WriteAllText(filePath, content);
            Console.WriteLine("Текст успешно записан в файл.");
        }
    }
}
