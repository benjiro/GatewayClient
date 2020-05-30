namespace GatewayClient.Models
{
    using System.Text.Json.Serialization;

    public class SystemStatus
    {
        [JsonPropertyName("percentage")]
        public double Percentage { get; set; }
    }
}