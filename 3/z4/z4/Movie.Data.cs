namespace MovieNamespace
{
    public partial class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public double Duration { get; set; }
        public string Genre { get; set; }

        public Movie(string title, string director, double duration, string genre)
        {
            Title = title;
            Director = director;
            Duration = duration;
            Genre = genre;
        }
    }
}
