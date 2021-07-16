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
       public string smartContract {get; set;} = "";
       public bool visible {get; set;}
    }
}