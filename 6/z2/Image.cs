namespace ImageNamespace
{
    public delegate void ImageProcessor(string path);

    public class Image
    {
        public void ProcessImage(ImageProcessor proc, string path)
        {
            Console.WriteLine($"Обработка изображения: {path}");
            proc(path);
        }

        public void ResizeImage(string path)
        {
            Console.WriteLine($"Изменение размера изображения: {path}");
        }

        public void ConvertToGrayscale(string path)
        {
            Console.WriteLine($"Конвертация изображения в оттенки серого: {path}");
        }
    }
}
