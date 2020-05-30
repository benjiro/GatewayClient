namespace GatewayClient.Models
{
    using System.Text.Json.Serialization;

    public class GridStatus
    {
        [JsonPropertyName("grid_status")]
        public string GridStatusGridStatus { get; set; }

        [JsonPropertyName("grid_services_active")]
        public bool GridServicesActive { get; set; }
    }
}