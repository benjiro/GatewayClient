namespace GatewayClient.Models
{
    using System.Text.Json.Serialization;

    public class SiteMaster
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("running")]
        public bool Running { get; set; }

        [JsonPropertyName("connected_to_tesla")]
        public bool ConnectedToTesla { get; set; }
    }
}