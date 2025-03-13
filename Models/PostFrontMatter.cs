using YamlDotNet.Serialization;

namespace BlazorPortfolio.Models {
    public class PostFrontMatter
    {    
        [YamlMember(Alias = "date")]
        public string Date { get; set; }
        [YamlMember(Alias = "hours")]
        public int Hours { get; set; }
        
        [YamlMember(Alias = "satisfaction")]
        public int Satisfaction { get; set; }
    }
}