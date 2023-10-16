using ExternalApiConsumption.Models;
using ExternalApiConsumption.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalApiConsumption.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieInfoController : ControllerBase
    {
        private IMovieInfoService _movieInforService ;
        public MovieInfoController(IMovieInfoService movieInfoService)
        {
            _movieInforService = movieInfoService;
        }

        [HttpGet]
        public Task<JsonData> Get()
        {
            return _movieInforService.GetMovies();

        }
    }
}
