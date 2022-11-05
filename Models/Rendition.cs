using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Rendition
    {
        [JsonProperty("aspect")]
        [JsonPropertyName("aspect")]
        public string Aspect;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("maximum_bit_rate")]
        [JsonPropertyName("maximum_bit_rate")]
        public int? MaximumBitRate;

        [JsonProperty("poster_url")]
        [JsonPropertyName("poster_url")]
        public string PosterUrl;

        [JsonProperty("file_size")]
        [JsonPropertyName("file_size")]
        public int? FileSize;

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url;

        [JsonProperty("content_type")]
        [JsonPropertyName("content_type")]
        public string ContentType;

        [JsonProperty("width")]
        [JsonPropertyName("width")]
        public int Width;

        [JsonProperty("minimum_bit_rate")]
        [JsonPropertyName("minimum_bit_rate")]
        public int? MinimumBitRate;

        [JsonProperty("height")]
        [JsonPropertyName("height")]
        public int Height;

        [JsonProperty("container")]
        [JsonPropertyName("container")]
        public string Container;

        [JsonProperty("duration")]
        [JsonPropertyName("duration")]
        public int Duration;

        [JsonProperty("bit_rate")]
        [JsonPropertyName("bit_rate")]
        public int? BitRate;
    }



}