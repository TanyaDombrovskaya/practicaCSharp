namespace MovieNamespace
{
    public class Cinema
    {
        private Movie[] Movies { get; set; }

        public Cinema(Movie[] movies)
        {
            Movies = movies;
        }

        public Movie GetLongestMovie()
        {
            return Movies.OrderByDescending(m => m.Duration).FirstOrDefault();
        }

        public Movie[] GetMoviesByDirector(string director)
        {
            return Movies.Where(o => o.Director.Equals(director, StringComparison.OrdinalIgnoreCase)).ToArray();
        }
    }
}
