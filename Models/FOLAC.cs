using Newtonsoft.Json;

namespace API_cook.Models
{
   
    
        public class FOLAC
        {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }


    
}