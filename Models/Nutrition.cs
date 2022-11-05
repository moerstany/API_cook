using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Nutrition
    {
        [JsonProperty("fat")]
        [JsonPropertyName("fat")]
        public int Fat;

        [JsonProperty("calories")]
        [JsonPropertyName("calories")]
        public int Calories;

        [JsonProperty("sugar")]
        [JsonPropertyName("sugar")]
        public int Sugar;

        [JsonProperty("carbohydrates")]
        [JsonPropertyName("carbohydrates")]
        public int Carbohydrates;

        [JsonProperty("fiber")]
        [JsonPropertyName("fiber")]
        public int Fiber;

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt;

        [JsonProperty("protein")]
        [JsonPropertyName("protein")]
        public int Protein;
    }



}