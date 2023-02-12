using MovieAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAssignment.Services
{
    public interface IMovieService
    {
        public Task<OMDBMovie> GetMovieDetails(string movieName);
        public Task SaveQuery(OMDBMovie result);
    }
}
