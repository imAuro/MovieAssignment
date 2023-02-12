using System;

namespace MovieAssignment
{
    public class MovieDetails
    {
        public int ID { get; set; }

        public string SearchToken { get; set; }

        public string ImdbID { get; set; }

        public int ProcessingTimeMs { get; set; }

        public DateTime TimeStamp { get; set; }

        public string IPAddress { get; set; }
    }
}

