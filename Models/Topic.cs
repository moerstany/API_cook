using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Topic
    {
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;
    }



}