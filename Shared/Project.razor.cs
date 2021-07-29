namespace BlazoredPortfolio.Shared
{
    public class ProjectBase : Microsoft.AspNetCore.Components.ComponentBase 
    {
       public string description {get; set;}
       public string[] madeWith {get; set;} 
       public string photoLink {get; set;}
       public string photoDimension {get; set;}
       public string title {get; set;}
       public string sourceLink {get; set;}
       public string siteLink {get; set;}
       public string photoStructure {get; set; } = "";
       public ImageTag[] ImgStructure {get; set; } = new ImageTag[]{};
       public string smartContract {get; set; } = "";
       public bool visible {get; set;}
    }
    public struct ImageTag
    {
        public int size {get; set;}
        public string imgRatio {get; set;}
        public string imgUrl {get; set;}
        public ImageTag(int size, string imgRatio, string imgUrl)
    {
        this.size = size;
        this.imgRatio = imgRatio;
        this.imgUrl = imgUrl;
    }
           
    }
}