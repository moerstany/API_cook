using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Root
    {
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int Count;

        [JsonProperty("results")]
        [JsonPropertyName("results")]
        public Result[] Results;
    }



}