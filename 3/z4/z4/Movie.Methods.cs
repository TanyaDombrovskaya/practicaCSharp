namespace MovieNamespace
{
    partial class Movie
    {
        public void Show()
        {
            Console.WriteLine($"    Название: {Title}");
            Console.WriteLine($"    Режиссёр: {Director}");
            Console.WriteLine($"    Длительность: {Duration} часов");
            Console.WriteLine($"    Жанр: {Genre} \n");
        }
    }
}
