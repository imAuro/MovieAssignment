using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieAssignment.Services
{
	public class AdminService : IAdminService
	{
		public AdminService()
		{
		}

        public bool DeleteMovieDetailsByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<MovieDetails> GetAllDetails()
        {
            throw new NotImplementedException();
            //take one thread fetech all the details of movie from open db database // 10 mins
            // one thread // 1 min 

        }

        public List<MovieDetails> GetMovieDetailsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public MovieDetails GetMovieDetailsByID(string id)
        {
            throw new NotImplementedException();
        }

        public int GetReportUsage(DateTime date)
        {
            throw new NotImplementedException();
        }

        
    }
}

