using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Compilation
    {
        [JsonProperty("aspect_ratio")]
        [JsonPropertyName("aspect_ratio")]
        public string AspectRatio;

        [JsonProperty("show")]
        [JsonPropertyName("show")]
        public List<Show> Show;

        [JsonProperty("video_url")]
        [JsonPropertyName("video_url")]
        public string VideoUrl;

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id;

        [JsonProperty("beauty_url")]
        [JsonPropertyName("beauty_url")]
        public object BeautyUrl;

        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug;

        [JsonProperty("promotion")]
        [JsonPropertyName("promotion")]
        public string Promotion;

        [JsonProperty("video_id")]
        [JsonPropertyName("video_id")]
        public int VideoId;

        [JsonProperty("keywords")]
        [JsonPropertyName("keywords")]
        public object Keywords;

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description;

        [JsonProperty("draft_status")]
        [JsonPropertyName("draft_status")]
        public string DraftStatus;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("is_shoppable")]
        [JsonPropertyName("is_shoppable")]
        public bool IsShoppable;

        [JsonProperty("thumbnail_alt_text")]
        [JsonPropertyName("thumbnail_alt_text")]
        public string ThumbnailAltText;

        [JsonProperty("approved_at")]
        [JsonPropertyName("approved_at")]
        public int ApprovedAt;

        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public string Language;

        [JsonProperty("thumbnail_url")]
        [JsonPropertyName("thumbnail_url")]
        public string ThumbnailUrl;

        [JsonProperty("canonical_id")]
        [JsonPropertyName("canonical_id")]
        public string CanonicalId;

        [JsonProperty("buzz_id")]
        [JsonPropertyName("buzz_id")]
        public int? BuzzId;

        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country;

        [JsonProperty("facebook_posts")]
        [JsonPropertyName("facebook_posts")]
        public List<object> FacebookPosts;

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public int CreatedAt;
    }



}