using ExternalApiConsumption.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ExternalApiConsumption.Services
{
    public class MovieInfoService : IMovieInfoService
    {
        HttpClient client = new HttpClient();
        public async Task<JsonData> GetMovies()
        {


            try
            {
                //HttpContent content = new StringContent(JsonConvert.SerializeObject(new { }));
               // content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                //Uri uri = new Uri("https://fake-movie-database-api.herokuapp.com/api?s=batman");
                //HttpResponseMessage response = await client.PostAsync(uri , content);
                //return





                Uri uri = new Uri("https://fake-movie-database-api.herokuapp.com/api?s=batman");
                HttpResponseMessage response = await client.GetAsync(uri);
                if(response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var data= JsonConvert.DeserializeObject<JsonData>(result);
                    return data;
                }
                return null;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
