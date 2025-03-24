using ImageNamespace;

class Task2
{
    static void Main()
    {
        Image image = new();

        ImageProcessor resize = image.ResizeImage;
        ImageProcessor grayscale = image.ConvertToGrayscale;

        string path = "example.jpg";

        Console.WriteLine("Выполнение изменения размера:");
        image.ProcessImage(resize, path);

        Console.WriteLine("\nВыполнение конвертации в оттенки серого:");
        image.ProcessImage(grayscale, path);
    }
}