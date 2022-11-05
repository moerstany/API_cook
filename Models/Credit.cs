using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Credit
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type;
    }



}