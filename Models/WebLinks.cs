namespace WebLinks.Models
{
    public class WebLinks
    {
        public int WebId {get; set;}
        public string AppName {get; set;} = "";
        public string Site {get; set;} = "";
        public string Environment {get; set;} = "";
        public string AppShortName {get; set;} = "";
        public string SupportTeam {get; set;} = "";
        public string Url {get; set;} = "";
        public string HostServer {get; set;} = "";
        public string DbServer {get; set;} = "";
    }
}