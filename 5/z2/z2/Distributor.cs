namespace CinemaNamespace
{
    class Distributor
    {
        public string Name { get; set; }

        public Distributor(string name)
        {
            Name = name;
        }

        public void DeliverMovies(Cinema cinema, Movie[] movies)
        {
            cinema.Movies = movies;
            Console.WriteLine($"Дистрибьютор {Name} поставил фильмы в кинотеатр {cinema.Name}.");
        }
    }
}
