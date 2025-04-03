using System;

namespace Cinoteatr
{
    public class MovieModel
    {
        public string Title { get; set; }
        public DateTime SessionTime { get; set; }

        public MovieModel(string title, DateTime sessionTime)
        {
            Title = title;
            SessionTime = sessionTime;
        }
    }
}
