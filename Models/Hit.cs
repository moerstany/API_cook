using Newtonsoft.Json;

namespace API_cook.Models
{
    
    
        public class Hit
        {
        [JsonProperty("recipe")]
        public Recipe Recipe { get; set; }
        }


    
}