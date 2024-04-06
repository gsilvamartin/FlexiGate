namespace FlexiGate.Gateway.Configuration
{
    public class Host
    {
        public string Hostname { get; set; } = "localhost";
        public string[] AllowedOrigins { get; set; } = { "*" };
        public string[] AllowedMethods { get; set; } = {"GET", "POST", "PUT" };
        public string AllowedHeaders { get; set; } = "Content-Type";
        public bool AllowCredential { get; set; } = true;
        public int MaxAge { get; set; } = 600;
        public bool AllowAnyHeader { get; set; } = false;
        public bool AllowAnyMethod { get; set; } = false;
        public bool AllowAnyOrigin { get; set; } = false;
        public IEnumerable<Host> Hosts { get; set; } = new List<Host>(); 
    }
}