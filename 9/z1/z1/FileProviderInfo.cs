namespace FileNamespace
{
    public class FileProviderInfo
    {
        private FileInfo _fileInfo;

        public FileProviderInfo(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Путь к файлу не может быть пустым или содержать только пробелы.", nameof(path));
            }

            _fileInfo = new FileInfo(path);

            if (!_fileInfo.Exists)
            {
                throw new FileNotFoundException($"Файл по пути '{path}' не найден.");
            }
        }

        public long SizeFile()
        {
            return _fileInfo.Length;
        }

        public DateTime CreatingDateOfFile()
        {
            return _fileInfo.CreationTime;
        }

        public DateTime LastWriteOfFile()
        { 
            return _fileInfo.LastWriteTime;
        }
    }
}
