using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieAssignment.Services
{
    public interface IAdminService
    {

        // Add the methods here
        bool DeleteMovieDetailsByID(string id);
        public List<MovieDetails> GetAllDetails();
        public List<MovieDetails>GetMovieDetailsByDate(DateTime date);
        public MovieDetails GetMovieDetailsByID(string id);
        public int GetReportUsage(DateTime date);
    }
}

