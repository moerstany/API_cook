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
        public CookApiService()//инициализировали
        {   //https://api.edamam.com/search?q=chicken&app_id=5ac8ac40&app_key=422c5935a5f0c1ada32f47d9108dcf61&from=0&to=3&calories=591-722&health=alcohol-free
            BaseUrl = "https://api.edamam.com/search";
            ApiId ="5ac8ac40";
            ApiKey ="422c5935a5f0c1ada32f47d9108dcf61";
            httpClient = new HttpClient();
        }
        public async Task<Root> SearchByTitle (string title)
        {
            
            var response = await httpClient.GetAsync($"{BaseUrl}?q={title}&app_id={ApiId}&app_key={ApiKey}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<Root>(json);
            Console.WriteLine(result);
            return result;
        }
    }
}
