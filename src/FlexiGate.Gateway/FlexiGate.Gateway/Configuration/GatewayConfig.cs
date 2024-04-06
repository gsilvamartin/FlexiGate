namespace FlexiGate.Gateway.Configuration
{
    public class GatewayConfig
    {
        public bool UseHttps { get; set; } = true;
        public int HttpsPort { get; set; } = 443;
        public int HttpPort { get; set; } = 80;
    }
}