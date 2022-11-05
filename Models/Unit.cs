using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Unit
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("display_plural")]
        [JsonPropertyName("display_plural")]
        public string DisplayPlural;

        [JsonProperty("display_singular")]
        [JsonPropertyName("display_singular")]
        public string DisplaySingular;

        [JsonProperty("abbreviation")]
        [JsonPropertyName("abbreviation")]
        public string Abbreviation;

        [JsonProperty("system")]
        [JsonPropertyName("system")]
        public string System;
    }



}