namespace API_cook.Models
{
    
    
        public class Root
        {
            public string q { get; set; }
            public int from { get; set; }
            public int to { get; set; }
            public bool more { get; set; }
            public int count { get; set; }
            public List<Hit> hits { get; set; }
        }


    
}