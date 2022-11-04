namespace API_cook.Models
{
    
    
        public class Recipe
        {
            public string uri { get; set; }
            public string label { get; set; }
            public string image { get; set; }
            public string source { get; set; }
            public string url { get; set; }
            public string shareAs { get; set; }
            public int yield { get; set; }
            public List<string> dietLabels { get; set; }
            public List<string> healthLabels { get; set; }
            public List<string> cautions { get; set; }
            public List<string> ingredientLines { get; set; }
            public List<Ingredient> ingredients { get; set; }
            public double calories { get; set; }
            public double totalWeight { get; set; }
            public int totalTime { get; set; }
            public List<string> cuisineType { get; set; }
            public List<string> mealType { get; set; }
            public List<string> dishType { get; set; }
            public TotalNutrients totalNutrients { get; set; }
            public TotalDaily totalDaily { get; set; }
            public List<Digest> digest { get; set; }
        


    }
}