using Newtonsoft.Json;

namespace API_cook.Models
{
    
    
        public class Hit
        {
        [JsonProperty("recipe")]
        public List<Recipe>? Recipe { get; set; }
        }


    
}