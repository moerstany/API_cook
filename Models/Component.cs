using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Component
    {
        [JsonProperty("raw_text")]
        [JsonPropertyName("raw_text")]
        public string RawText;

        [JsonProperty("extra_comment")]
        [JsonPropertyName("extra_comment")]
        public string ExtraComment;

        [JsonProperty("ingredient")]
        [JsonPropertyName("ingredient")]
        public Ingredient Ingredient;

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id;

        [JsonProperty("position")]
        [JsonPropertyName("position")]
        public int Position;

        [JsonProperty("measurements")]
        [JsonPropertyName("measurements")]
        public List<Measurement> Measurements;
    }



}