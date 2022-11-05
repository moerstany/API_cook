using Newtonsoft.Json;

namespace API_cook.Models
{
    
    
        public class Root
        {
        [JsonProperty("q")]
        public string? Q { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("hits")]
        public Hit[] Hits { get; set; }
    }


    
}