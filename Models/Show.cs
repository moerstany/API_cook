using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Show
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;
    }



}