using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Search  
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("veg")]
        [JsonPropertyName("veg")]
        public bool Veg { get; set; }

        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("img")]
        [JsonPropertyName("img")]
        public string Img { get; set; }

        [JsonProperty("sizeandcrust")]
        [JsonPropertyName("sizeandcrust")]
        public List<Sizeandcrust> Sizeandcrust { get; set; }
    }


    //https://pizza-and-desserts.p.rapidapi.com/pizzas/?q=kebab&rapidapi-key=bcd760c999msh63ffa07e44061fbp1d8e32jsn27b4b51c06a9

}