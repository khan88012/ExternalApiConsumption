using Newtonsoft.Json;

namespace ExternalApiConsumption.Models
{
    public class JsonData
    {
        [JsonProperty("Search")]
        public List<MoviesInfo> Search { get; set; }

    }
}
