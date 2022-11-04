using Newtonsoft.Json;

namespace API_cook.Models
{
    
    
        public class Recipe
        {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("shareAs")]
        public string ShareAs { get; set; }

        [JsonProperty("yield")]
        public int Yield { get; set; }

        [JsonProperty("dietLabels")]
        public List<string> DietLabels { get; set; }

        [JsonProperty("healthLabels")]
        public List<string> HealthLabels { get; set; }

        [JsonProperty("cautions")]
        public List<string> Cautions { get; set; }

        [JsonProperty("ingredientLines")]
        public List<string> IngredientLines { get; set; }

        [JsonProperty("ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonProperty("calories")]
        public double Calories { get; set; }

        [JsonProperty("totalWeight")]
        public double TotalWeight { get; set; }

        [JsonProperty("totalTime")]
        public int TotalTime { get; set; }

        [JsonProperty("cuisineType")]
        public List<string> CuisineType { get; set; }

        [JsonProperty("mealType")]
        public List<string> MealType { get; set; }

        [JsonProperty("dishType")]
        public List<string> DishType { get; set; }

        [JsonProperty("totalNutrients")]
        public TotalNutrients TotalNutrients { get; set; }

        [JsonProperty("totalDaily")]
        public TotalDaily TotalDaily { get; set; }

        [JsonProperty("digest")]
        public List<Digest> Digest { get; set; }

    }


}