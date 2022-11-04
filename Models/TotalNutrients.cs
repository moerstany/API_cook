using Newtonsoft.Json;

namespace API_cook.Models
{

    
        public class TotalNutrients
        {
        [JsonProperty("ENERC_KCAL")]
        public ENERCKCAL ENERCKCAL { get; set; }

        [JsonProperty("FAT")]
        public FAT FAT { get; set; }

        [JsonProperty("FASAT")]
        public FASAT FASAT { get; set; }

        [JsonProperty("FATRN")]
        public FATRN FATRN { get; set; }

        [JsonProperty("FAMS")]
        public FAMS FAMS { get; set; }

        [JsonProperty("FAPU")]
        public FAPU FAPU { get; set; }

        [JsonProperty("CHOCDF")]
        public CHOCDF CHOCDF { get; set; }

        [JsonProperty("CHOCDF.net")]
        public CHOCDFNet CHOCDFNet { get; set; }

        [JsonProperty("FIBTG")]
        public FIBTG FIBTG { get; set; }

        [JsonProperty("SUGAR")]
        public SUGAR SUGAR { get; set; }

        [JsonProperty("SUGAR.added")]
        public SUGARAdded SUGARAdded { get; set; }

        [JsonProperty("PROCNT")]
        public PROCNT PROCNT { get; set; }

        [JsonProperty("CHOLE")]
        public CHOLE CHOLE { get; set; }

        [JsonProperty("NA")]
        public NA NA { get; set; }

        [JsonProperty("CA")]
        public CA CA { get; set; }

        [JsonProperty("MG")]
        public MG MG { get; set; }

        [JsonProperty("K")]
        public K K { get; set; }

        [JsonProperty("FE")]
        public FE FE { get; set; }

        [JsonProperty("ZN")]
        public ZN ZN { get; set; }

        [JsonProperty("P")]
        public P P { get; set; }

        [JsonProperty("VITA_RAE")]
        public VITARAE VITARAE { get; set; }

        [JsonProperty("VITC")]
        public VITC VITC { get; set; }

        [JsonProperty("THIA")]
        public THIA THIA { get; set; }

        [JsonProperty("RIBF")]
        public RIBF RIBF { get; set; }

        [JsonProperty("NIA")]
        public NIA NIA { get; set; }

        [JsonProperty("VITB6A")]
        public VITB6A VITB6A { get; set; }

        [JsonProperty("FOLDFE")]
        public FOLDFE FOLDFE { get; set; }

        [JsonProperty("FOLFD")]
        public FOLFD FOLFD { get; set; }

        [JsonProperty("FOLAC")]
        public FOLAC FOLAC { get; set; }

        [JsonProperty("VITB12")]
        public VITB12 VITB12 { get; set; }

        [JsonProperty("VITD")]
        public VITD VITD { get; set; }

        [JsonProperty("TOCPHA")]
        public TOCPHA TOCPHA { get; set; }

        [JsonProperty("VITK1")]
        public VITK1 VITK1 { get; set; }

        [JsonProperty("Sugar.alcohol")]
        public SugarAlcohol SugarAlcohol { get; set; }

        [JsonProperty("WATER")]
        public WATER WATER { get; set; }
    }


    
}