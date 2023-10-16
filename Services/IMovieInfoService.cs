using ExternalApiConsumption.Models;

namespace ExternalApiConsumption.Services
{
    public interface IMovieInfoService
    {
        public Task<JsonData> GetMovies();
    }
}
