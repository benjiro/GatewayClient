namespace GatewayClient.Models
{
    using System.Text.Json.Serialization;

    public class RegistrationInformation
    {
        [JsonPropertyName("privacy_notice")]
        public bool PrivacyNotice { get; set; }

        [JsonPropertyName("limited_warranty")]
        public bool LimitedWarranty { get; set; }

        [JsonPropertyName("grid_services")]
        public bool GridServices { get; set; }

        [JsonPropertyName("marketing")]
        public bool Marketing { get; set; }

        [JsonPropertyName("registered")]
        public bool Registered { get; set; }

        [JsonPropertyName("timed_out_registration")]
        public bool TimedOutRegistration { get; set; }
    }
}