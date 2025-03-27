namespace WatcherNS
{
    public class FileWatcher
    {
        private readonly FileSystemWatcher _watcher;
        private readonly string _directoryPath;

        public FileWatcher(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException($"Директория '{directoryPath}' не найдена.");
            }

            _directoryPath = directoryPath;
            _watcher = new FileSystemWatcher(directoryPath)
            {
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.DirectoryName
            };

            _watcher.Created += OnCreated;
            _watcher.Deleted += OnDeleted;
            _watcher.Changed += OnChanged;
            _watcher.Renamed += OnRenamed;
        }

        public void StartWatching()
        {
            _watcher.EnableRaisingEvents = true;
            Console.WriteLine($"Начато отслеживание изменений в папке: {_directoryPath}");
        }

        public void StopWatching()
        {
            _watcher.EnableRaisingEvents = false;
            Console.WriteLine($"Остановлено отслеживание изменений в папке: {_directoryPath}");
        }

        private int CountFiles()
        {
            return Directory.GetFiles(_directoryPath).Length;
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Файл создан: {e.Name}");
            Console.WriteLine($"Общее количество файлов: {CountFiles()}");
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Файл удалён: {e.Name}");
            Console.WriteLine($"Общее количество файлов: {CountFiles()}");
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Файл изменён: {e.Name}");
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Файл переименован: {e.OldName} -> {e.Name}");
            Console.WriteLine($"Общее количество файлов: {CountFiles()}");
        }
    }
}
