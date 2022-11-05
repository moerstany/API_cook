using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Result
    {
        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public int UpdatedAt;

        [JsonProperty("video_ad_content")]
        [JsonPropertyName("video_ad_content")]
        public string VideoAdContent;

        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug;

        [JsonProperty("servings_noun_singular")]
        [JsonPropertyName("servings_noun_singular")]
        public string ServingsNounSingular;

        [JsonProperty("tips_and_ratings_enabled")]
        [JsonPropertyName("tips_and_ratings_enabled")]
        public bool TipsAndRatingsEnabled;

        [JsonProperty("draft_status")]
        [JsonPropertyName("draft_status")]
        public string DraftStatus;

        [JsonProperty("inspired_by_url")]
        [JsonPropertyName("inspired_by_url")]
        public object InspiredByUrl;

        [JsonProperty("thumbnail_url")]
        [JsonPropertyName("thumbnail_url")]
        public string ThumbnailUrl;

        [JsonProperty("approved_at")]
        [JsonPropertyName("approved_at")]
        public int ApprovedAt;

        [JsonProperty("nutrition_visibility")]
        [JsonPropertyName("nutrition_visibility")]
        public string NutritionVisibility;

        [JsonProperty("prep_time_minutes")]
        [JsonPropertyName("prep_time_minutes")]
        public object PrepTimeMinutes;

        [JsonProperty("show")]
        [JsonPropertyName("show")]
        public Show Show;

        [JsonProperty("brand_id")]
        [JsonPropertyName("brand_id")]
        public object BrandId;

        [JsonProperty("buzz_id")]
        [JsonPropertyName("buzz_id")]
        public object BuzzId;

        [JsonProperty("video_url")]
        [JsonPropertyName("video_url")]
        public string VideoUrl;

        [JsonProperty("renditions")]
        [JsonPropertyName("renditions")]
        public List<Rendition> Renditions;

        [JsonProperty("original_video_url")]
        [JsonPropertyName("original_video_url")]
        public string OriginalVideoUrl;

        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country;

        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public string Language;

        [JsonProperty("show_id")]
        [JsonPropertyName("show_id")]
        public int ShowId;

        [JsonProperty("promotion")]
        [JsonPropertyName("promotion")]
        public string Promotion;

        [JsonProperty("total_time_minutes")]
        [JsonPropertyName("total_time_minutes")]
        public object TotalTimeMinutes;

        [JsonProperty("beauty_url")]
        [JsonPropertyName("beauty_url")]
        public object BeautyUrl;

        [JsonProperty("keywords")]
        [JsonPropertyName("keywords")]
        public string Keywords;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public int CreatedAt;

        [JsonProperty("is_one_top")]
        [JsonPropertyName("is_one_top")]
        public bool IsOneTop;

        [JsonProperty("is_shoppable")]
        [JsonPropertyName("is_shoppable")]
        public bool IsShoppable;

        [JsonProperty("seo_title")]
        [JsonPropertyName("seo_title")]
        public object SeoTitle;

        [JsonProperty("cook_time_minutes")]
        [JsonPropertyName("cook_time_minutes")]
        public object CookTimeMinutes;

        [JsonProperty("instructions")]
        [JsonPropertyName("instructions")]
        public List<Instruction> Instructions;

        [JsonProperty("num_servings")]
        [JsonPropertyName("num_servings")]
        public int NumServings;

        [JsonProperty("aspect_ratio")]
        [JsonPropertyName("aspect_ratio")]
        public string AspectRatio;

        [JsonProperty("canonical_id")]
        [JsonPropertyName("canonical_id")]
        public string CanonicalId;

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public object Description;

        [JsonProperty("topics")]
        [JsonPropertyName("topics")]
        public List<Topic> Topics;

        [JsonProperty("yields")]
        [JsonPropertyName("yields")]
        public string Yields;

        [JsonProperty("total_time_tier")]
        [JsonPropertyName("total_time_tier")]
        public object TotalTimeTier;

        [JsonProperty("video_id")]
        [JsonPropertyName("video_id")]
        public int VideoId;

        [JsonProperty("user_ratings")]
        [JsonPropertyName("user_ratings")]
        public UserRatings UserRatings;

        [JsonProperty("thumbnail_alt_text")]
        [JsonPropertyName("thumbnail_alt_text")]
        public string ThumbnailAltText;

        [JsonProperty("servings_noun_plural")]
        [JsonPropertyName("servings_noun_plural")]
        public string ServingsNounPlural;

        [JsonProperty("sections")]
        [JsonPropertyName("sections")]
        public List<Section> Sections;

        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public List<Tag> Tags;

        [JsonProperty("nutrition")]
        [JsonPropertyName("nutrition")]
        public Nutrition Nutrition;

        [JsonProperty("compilations")]
        [JsonPropertyName("compilations")]
        public List<Compilation> Compilations;

        [JsonProperty("credits")]
        [JsonPropertyName("credits")]
        public List<Credit> Credits;

        [JsonProperty("facebook_posts")]
        [JsonPropertyName("facebook_posts")]
        public List<object> FacebookPosts;

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id;

        [JsonProperty("brand")]
        [JsonPropertyName("brand")]
        public object Brand;
    }



}