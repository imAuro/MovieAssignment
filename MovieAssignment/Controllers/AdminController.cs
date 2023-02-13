using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieAssignment.Services;

namespace MovieAssignment.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class AdminController : ControllerBase
    {

        private IAdminService _adminService;
        public AdminController(ILogger<AdminController> logger, IAdminService adminSerice)
        {
            _adminService = adminSerice;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Test()
        {
           
            return Ok("API is working");
        }

        [HttpGet]
        public IActionResult GetAllDetails()
        {
            var rng = new Random();
            var result = _adminService.GetAllDetails();

            return Ok(result);
        }


        [HttpGet]
        [Authorize]
        public ActionResult GetMovieDetailsByID(string id)
        {

            var result = _adminService.GetMovieDetailsByID(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetMovieDetailsByDate(DateTime date)
        {

            var result = _adminService.GetMovieDetailsByDate(date);
            return Ok(result);

        }

        [HttpGet]
        public IActionResult GetReportUsage(DateTime date)
        {
            var result = _adminService.GetReportUsage(date);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteMovieDetailsById(string id)
        {
            var result = _adminService.DeleteMovieDetailsByID(id);

            return Ok(result);

        }




    }
}

