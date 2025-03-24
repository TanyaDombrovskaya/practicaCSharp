using FileNamespace;

delegate void FileHandler(string message);

class Task1
{    
    static void Main()
    {
        FileWriter fileWriter = new();
        FileReader fileReader = new();

        FileHandler writeHandler = fileWriter.WriteFile;
        FileHandler readHandeler = fileReader.ReadFile;

        string filePath = "test.txt";

        Console.WriteLine("Выполняется запись в файл...");
        writeHandler(filePath);

        Console.WriteLine("\nВыполняется чтение из файла...");
        readHandeler(filePath);
    }
}