using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_cook.Models
{
    public class Sizeandcrust
    {
        [JsonProperty("mediumPan")]
        [JsonPropertyName("mediumPan")]
        public List<MediumPan> MediumPan { get; set; }

        [JsonProperty("mediumstuffedcrustcheesemax")]
        [JsonPropertyName("mediumstuffedcrustcheesemax")]
        public List<Mediumstuff> Mediumstuff { get; set; }

        [JsonProperty("mediumstuffedcrustvegkebab")]
        [JsonPropertyName("mediumstuffedcrustvegkebab")]
        public List<Mediumskebab> Mediumskebab { get; set; }
    }


    //https://pizza-and-desserts.p.rapidapi.com/pizzas/?q=kebab&rapidapi-key=bcd760c999msh63ffa07e44061fbp1d8e32jsn27b4b51c06a9

}