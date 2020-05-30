namespace GatewayClient.Models
{
    using System.Text.Json.Serialization;

    public class SiteName
    {
        [JsonPropertyName("max_system_energy_kWh")]
        public long MaxSystemEnergyKWh { get; set; }

        [JsonPropertyName("max_system_power_kW")]
        public long MaxSystemPowerKW { get; set; }

        [JsonPropertyName("site_name")]
        public string SiteNameSiteName { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }
    }
}