namespace API_cook.Models
{
    public partial class ErrorViewModel
    {
        public class Sub
        {
            public string label { get; set; }
            public string tag { get; set; }
            public string schemaOrgTag { get; set; }
            public double total { get; set; }
            public bool hasRDI { get; set; }
            public double daily { get; set; }
            public string unit { get; set; }
        }


    }
}