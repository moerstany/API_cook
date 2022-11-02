namespace API_cook.Servises
{
    public class CookApiService//создали объекты в классе
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        
        private HttpClient httpClient;
        public CookApiService()//инициализировали
        {   //https://api.spoonacular.com/food/products/search/?apiKey=72d9d866960d4beab8ef876566b4782d&query={title}
            BaseUrl = "https://api.spoonacular.com/food/products/search/";
            ApiKey = "72d9d866960d4beab8ef876566b4782d";
            httpClient = new HttpClient();
        }
        public async Task<string> SearchByTitle (string title)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"{BaseUrl}?apiKey={ApiKey}&query={title}");
            var result = await response.Content.ReadAsStringAsync();
            
            Console.WriteLine(result);
            return result;
        }
    }
}
