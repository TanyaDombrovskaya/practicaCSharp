using System;

namespace Cinoteatr
{
    public class MovieSession
    {
        public string MovieTitle { get; set; }
        public DateTime SessionTime { get; set; }

        public MovieSession(string title, DateTime time)
        {
            MovieTitle = title;
            SessionTime = time;
        }
    }
}
