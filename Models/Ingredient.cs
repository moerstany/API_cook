using Newtonsoft.Json;

namespace API_cook.Models
{
    
        public class Ingredient
        {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }

        [JsonProperty("food")]
        public string Food { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("foodCategory")]
        public string FoodCategory { get; set; }

        [JsonProperty("foodId")]
        public string FoodId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }


    
}