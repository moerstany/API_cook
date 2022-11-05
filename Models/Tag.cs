using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Tag
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id;

        [JsonProperty("display_name")]
        [JsonPropertyName("display_name")]
        public string DisplayName;

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type;
    }



}