namespace GatewayClient.Models
{
    using System.Text.Json.Serialization;

    public class Battery : AggregateBase
    {
        [JsonPropertyName("percentage")]
        public double Percentage { get; set; }
    }
}