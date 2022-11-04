using Newtonsoft.Json;

namespace API_cook.Models
{
   
    
        public class FAT
        {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }


    
}