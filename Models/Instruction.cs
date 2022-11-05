using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Instruction
    {
        [JsonProperty("end_time")]
        [JsonPropertyName("end_time")]
        public int EndTime;

        [JsonProperty("temperature")]
        [JsonPropertyName("temperature")]
        public int? Temperature;

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id;

        [JsonProperty("position")]
        [JsonPropertyName("position")]
        public int Position;

        [JsonProperty("display_text")]
        [JsonPropertyName("display_text")]
        public string DisplayText;

        [JsonProperty("start_time")]
        [JsonPropertyName("start_time")]
        public int StartTime;

        [JsonProperty("appliance")]
        [JsonPropertyName("appliance")]
        public string Appliance;
    }



}