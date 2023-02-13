using Microsoft.AspNetCore.Mvc;
using MovieAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAssignment.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MovieController : ControllerBase
    {

        public IMovieService _movieService;

        public MovieController( OMDBMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> GetMovieDetails(string movieName)
        {
            var result=await _movieService.GetMovieDetails(movieName);
            if(result==null)
            {
                return NotFound();
            }
            else
            {
                await _movieService.SaveQuery(result);
                return Ok(result);
            }
        }
    }
}
