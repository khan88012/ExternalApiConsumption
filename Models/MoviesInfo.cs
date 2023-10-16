using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ExternalApiConsumption.Models
{
    public class MoviesInfo
    {
        [JsonProperty("imdbID")]
        public string? ImdbID { get; set; }
        [JsonProperty("Title")]
        public string? Title { get; set; }

        [JsonProperty("Year")]
        public int? Year { get; set; }
        [JsonProperty("Poster")]
        public string? Poster { get; set; }
    }
}
