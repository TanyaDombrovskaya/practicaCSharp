using WatcherNS;

class Task4
{
    static void Main()
    {
        Console.Write("Введите путь к папке для отслеживания: ");
        string directoryPath = Console.ReadLine();

        try
        {
            FileWatcher fileWatcher = new FileWatcher(directoryPath);
            fileWatcher.StartWatching();

            Console.WriteLine("Нажмите Enter для остановки отслеживания...");
            Console.ReadLine();

            fileWatcher.StopWatching();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
