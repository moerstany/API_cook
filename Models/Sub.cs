using Newtonsoft.Json;

namespace API_cook.Models
{
   
    
        public class Sub
        {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("schemaOrgTag")]
        public string SchemaOrgTag { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("hasRDI")]
        public bool HasRDI { get; set; }

        [JsonProperty("daily")]
        public double Daily { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }


    
}