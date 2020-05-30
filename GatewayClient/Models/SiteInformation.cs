namespace GatewayClient.Models
{
    using System.Text.Json.Serialization;

    public class SiteInformation
    {
        [JsonPropertyName("max_site_meter_power_kW")]
        public long MaxSiteMeterPowerKW { get; set; }

        [JsonPropertyName("min_site_meter_power_kW")]
        public long MinSiteMeterPowerKW { get; set; }

        [JsonPropertyName("nominal_system_energy_kWh")]
        public double NominalSystemEnergyKWh { get; set; }

        [JsonPropertyName("nominal_system_power_kW")]
        public long NominalSystemPowerKW { get; set; }

        [JsonPropertyName("max_system_energy_kWh")]
        public long MaxSystemEnergyKWh { get; set; }

        [JsonPropertyName("max_system_power_kW")]
        public long MaxSystemPowerKW { get; set; }

        [JsonPropertyName("site_name")]
        public string SiteName { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("grid_code")]
        public string GridCode { get; set; }

        [JsonPropertyName("grid_voltage_setting")]
        public long GridVoltageSetting { get; set; }

        [JsonPropertyName("grid_freq_setting")]
        public long GridFreqSetting { get; set; }

        [JsonPropertyName("grid_phase_setting")]
        public string GridPhaseSetting { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("distributor")]
        public string Distributor { get; set; }

        [JsonPropertyName("utility")]
        public string Utility { get; set; }

        [JsonPropertyName("retailer")]
        public string Retailer { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }
    }
}