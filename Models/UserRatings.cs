using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class UserRatings
    {
        [JsonProperty("count_negative")]
        [JsonPropertyName("count_negative")]
        public int CountNegative;

        [JsonProperty("count_positive")]
        [JsonPropertyName("count_positive")]
        public int CountPositive;

        [JsonProperty("score")]
        [JsonPropertyName("score")]
        public double Score;
    }



}