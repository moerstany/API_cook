using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Ingredient
    {
        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public int UpdatedAt;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public int CreatedAt;

        [JsonProperty("display_plural")]
        [JsonPropertyName("display_plural")]
        public string DisplayPlural;

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id;

        [JsonProperty("display_singular")]
        [JsonPropertyName("display_singular")]
        public string DisplaySingular;
    }



}