namespace CinemaNamespace
{
    class Cinema
    {
        public string Name { get; set; }
        public Movie[] Movies { get; set; }
        private Shedule _shedule { get; set; }
        public Distributor Distributor { get; set; }

        public Cinema(string name, string[] timeSlots, Distributor distributor)
        {
            Name = name;
            _shedule = new Shedule(timeSlots);
            Distributor = distributor;
        }

        public void ShowMovies()
        {
            Console.WriteLine($"Кинотеатр: {Name}");
            _shedule.ShowSchedule();

            if (Movies != null && Movies.Length > 0)
            {
                Console.WriteLine("Список фильмов:");
                foreach (Movie movie in Movies)
                {
                    movie.ShowInfo();
                }
            }
            else
            {
                Console.WriteLine("Нет доступных фильмов.");

            }
        }
    }
}
