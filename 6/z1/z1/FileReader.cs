namespace FileNamespace
{
    public class FileReader
    {
        public void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine($"Содержимое файла:\n{content}");
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }
        }
    }
}
