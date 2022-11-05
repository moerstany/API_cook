using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class MediumPan
    {
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public int Price { get; set; }
    }


    //https://pizza-and-desserts.p.rapidapi.com/pizzas/?q=kebab&rapidapi-key=bcd760c999msh63ffa07e44061fbp1d8e32jsn27b4b51c06a9

}