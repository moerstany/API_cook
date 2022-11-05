using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Measurement
    {
        [JsonProperty("unit")]
        [JsonPropertyName("unit")]
        public Unit Unit;

        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public string Quantity;

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id;
    }



}