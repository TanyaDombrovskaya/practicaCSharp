using FileNamespace;

class Task1
{
    static void Main()
    {
        Console.Write("Введите путь к файлу: ");
        string path = Console.ReadLine();

        FileManager manager = new(path);       
        manager.CreateFile();                  

        FileProviderInfo provider = new(path);

        Console.Write("\nВведите текст для записи в файл: ");
        string text = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(text);
                Console.WriteLine($"Текст успешно записан в файл: {path}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.Write("\nВведите путь для копии файла: ");
        string copyPath = Console.ReadLine();
        manager.CopyFile(copyPath);
        if (File.Exists(copyPath))
        {
            Console.WriteLine("Копия файла успешно создана.");
        }
        else
        {
            Console.WriteLine("Ошибка при создании копии файла.");
        }

        Console.Write("\nВведите новую директорию для перемещения файла: ");
        string newDirectory = Console.ReadLine();
        string newPath = Path.Combine(newDirectory, Path.GetFileName(path));
        manager.MoveFile(newPath);
        if (File.Exists(newPath))
        {
            Console.WriteLine($"Файл успешно перемещён в {newDirectory}.");
        }

        Console.Write("\nВведите новое имя файла (например, familiya.io): ");
        string newName = Console.ReadLine();
        string renamedPath = Path.Combine(newDirectory, newName);
        try
        {
            File.Move(newPath, renamedPath);
            Console.WriteLine($"Файл успешно переименован в {newName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при переименовании: {ex.Message}");
        }

        Console.Write("\nВведите путь к файлу для удаления: ");
        string deletePath = Console.ReadLine();
        try
        {
            if (File.Exists(deletePath))
            {
                File.Delete(deletePath);
                Console.WriteLine("Файл успешно удалён.");
            }
            else
            {
                Console.WriteLine("Файл не существует, удаление невозможно.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при удалении: {ex.Message}");
        }

        Console.Write("\nВведите путь к первому файлу для сравнения размера: ");
        string firstFile = Console.ReadLine();
        Console.Write("Введите путь ко второму файлу для сравнения размера: ");
        string secondFile = Console.ReadLine();
        try
        {
            FileInfo firstFileInfo = new FileInfo(firstFile);
            FileInfo secondFileInfo = new FileInfo(secondFile);
            if (firstFileInfo.Exists && secondFileInfo.Exists)
            {
                Console.WriteLine($"Размер первого файла: {firstFileInfo.Length} байт.");
                Console.WriteLine($"Размер второго файла: {secondFileInfo.Length} байт.");
                if (firstFileInfo.Length == secondFileInfo.Length)
                {
                    Console.WriteLine("Файлы имеют одинаковый размер.");
                }
                else
                {
                    Console.WriteLine("Файлы имеют разный размер.");
                }
            }
            else
            {
                Console.WriteLine("Один из файлов не существует.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при сравнении размеров: {ex.Message}");
        }

        Console.Write("\nВведите директорию для удаления файлов с расширением .ii: ");
        string directoryForDeletion = Console.ReadLine();
        try
        {
            var filesToDelete = Directory.GetFiles(directoryForDeletion, "*.ii");
            foreach (var file in filesToDelete)
            {
                File.Delete(file);
                Console.WriteLine($"Удалён файл: {file}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при удалении файлов: {ex.Message}");
        }

        Console.Write("\nВведите директорию для отображения списка файлов: ");
        string directoryToList = Console.ReadLine();
        try
        {
            var files = Directory.GetFiles(directoryToList);
            Console.WriteLine("\nСписок файлов:");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении списка файлов: {ex.Message}");
        }

        FileInfo fileToProtect = new FileInfo(renamedPath);
        try
        {
            fileToProtect.IsReadOnly = true;
            Console.WriteLine($"Запись в файл {renamedPath} запрещена.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при изменении прав доступа: {ex.Message}");
        }

        Console.WriteLine("\nПрава доступа к файлу:");
        Console.WriteLine($"Только чтение: {fileToProtect.IsReadOnly}");
        Console.WriteLine($"Файл доступен для записи: {!fileToProtect.IsReadOnly}");
    }
}
