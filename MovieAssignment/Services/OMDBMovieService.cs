using MovieAssignment.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace MovieAssignment.Services
{
    public class OMDBMovieService : IMovieService
    {
        private const string movieSourceURL = @"http://omdbapi.com/";
        HttpClient _httpClient;
        public OMDBMovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<OMDBMovie> GetMovieDetails(string movieName)
        {
            //call the imdbAPI and get the movie object.
            //OMDBMovie OMDBMovie = new OMDBMovie();
            _httpClient.BaseAddress = new Uri(movieSourceURL);
            var builder = new UriBuilder(movieSourceURL);
            builder.Port = -1;
            
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["t"] = movieName;
            builder.Query = query.ToString();
            string url = builder.ToString();
            HttpResponseMessage response=_httpClient.GetAsync(url).Result;
            
            var movie = "";
            if(response.IsSuccessStatusCode)
            {
                movie=await response.Content.ReadAsStringAsync();
            }
            var OMDBMovie=JsonConvert.DeserializeObject<OMDBMovie>(movie);
            

            return OMDBMovie;
        }

        public async Task SaveQuery(OMDBMovie result)
        {
            
            var movieDetails=new MovieDetails();
            movieDetails.ImdbID = result.IMDBID;

            //add it to the DB


        }
    }
}
