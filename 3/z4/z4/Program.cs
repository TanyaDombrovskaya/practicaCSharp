using MovieNamespace;

class Task4
{
    static void Main()
    {
        Movie[] movies = new Movie[]
        {
            new Movie("Интерстеллар", "Кристофер Нолан", 2.49, "Фантастика"),
            new Movie("Начало", "Кристофер Нолан", 2.28, "Фантастика"),
            new Movie("1+1", "Оливье Накаш", 1.52, "Драма"),
            new Movie("Гарри Поттер", "Крис Коламбус", 2.32, "Фэнтези")
        };

        Cinema cinema = new Cinema(movies);

        Console.WriteLine("Список фильмов:");

        foreach (var movie in movies)
        {
            movie.Show();
        }

        var longestMovie = cinema.GetLongestMovie();
        if (longestMovie != null)
        {
            Console.WriteLine("Фильм с самой длинной продолжительностью:");
            Console.WriteLine($"Название: {longestMovie.Title}, Длительность: {longestMovie.Duration} часов\n");
        }

        Console.Write("Введите имя:");
        string name = Console.ReadLine();

        Console.WriteLine($"\nФильмы режиссера {name}");
        var nolanMovies = cinema.GetMoviesByDirector(name);
        foreach (var movie in nolanMovies)
        {
            Console.WriteLine($"Название: {movie.Title}, Длительность: {movie.Duration} часов");
        }
    }
}