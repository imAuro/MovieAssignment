using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAssignment.Model
{
    public class OMDBMovie : Movie
    {
       
        public double IMDBRating { get; set; }
        public long IMDBVotes { get; set; }
        public string IMDBID { get; set; }
    }
}
