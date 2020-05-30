namespace GatewayClient.Models
{
    using System.Text.Json.Serialization;

    public class Aggregate
    {
        [JsonPropertyName("site")]
        public Site Site { get; set; }
        
        [JsonPropertyName("battery")]
        public Battery Battery { get; set; }
        
        [JsonPropertyName("load")]
        public Load Load { get; set; }
        
        [JsonPropertyName("solar")]
        public Solar Solar { get; set; }
        
        [JsonPropertyName("busway")]
        public AggregateBase Busway { get; set; }
        
        [JsonPropertyName("frequency")]
        public AggregateBase Frequency { get; set; }
        
        [JsonPropertyName("generator")]
        public AggregateBase Generator { get; set; }
    }
}