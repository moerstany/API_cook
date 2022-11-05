using API_cook.Models;
using System.Text.Json;

namespace API_cook.Servises
{
    public class CookApiService//создали объекты в классе
    {
        public string BaseUrl { get; set; }
        public string ApiId { get; set; }
        public string ApiKey { get; set; }
        
        private HttpClient httpClient;
        public CookApiService(IHttpClientFactory httpClientFactory)//инициализировали
        {   ////https://pizza-and-desserts.p.rapidapi.com/pizzas/?q=kebab&rapidapi-key=bcd760c999msh63ffa07e44061fbp1d8e32jsn27b4b51c06a9
            BaseUrl = "https://pizza-and-desserts.p.rapidapi.com/pizzas/";
            ApiId ="5ac8ac40";
            ApiKey = "bcd760c999msh63ffa07e44061fbp1d8e32jsn27b4b51c06a9";
            httpClient = httpClientFactory.CreateClient();
        }
        public async Task<Search> SearchByTitle (string title)
        {
            
            var response = await httpClient.GetAsync($"{BaseUrl}?q={title}&rapidapi-key={ApiKey}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<Search>(json);
            
            return result;

           
        }
    }
}
