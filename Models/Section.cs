using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Section
    {
        [JsonProperty("position")]
        [JsonPropertyName("position")]
        public int Position;

        [JsonProperty("components")]
        [JsonPropertyName("components")]
        public List<Component> Components;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public object Name;
    }



}