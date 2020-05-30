namespace GatewayClient.Models
{
    using System;
    using System.Text.Json.Serialization;
    
    public class CachedReadings
    {
        [JsonPropertyName("last_communication_time")]
        public DateTimeOffset LastCommunicationTime { get; set; }

        [JsonPropertyName("instant_power")]
        public long InstantPower { get; set; }

        [JsonPropertyName("instant_reactive_power")]
        public long InstantReactivePower { get; set; }

        [JsonPropertyName("instant_apparent_power")]
        public double InstantApparentPower { get; set; }

        [JsonPropertyName("frequency")]
        public long Frequency { get; set; }

        [JsonPropertyName("energy_exported")]
        public long EnergyExported { get; set; }

        [JsonPropertyName("energy_imported")]
        public long EnergyImported { get; set; }

        [JsonPropertyName("instant_average_voltage")]
        public double InstantAverageVoltage { get; set; }

        [JsonPropertyName("instant_total_current")]
        public long InstantTotalCurrent { get; set; }

        [JsonPropertyName("i_a_current")]
        public long IACurrent { get; set; }

        [JsonPropertyName("i_b_current")]
        public long IBCurrent { get; set; }

        [JsonPropertyName("i_c_current")]
        public long ICCurrent { get; set; }

        [JsonPropertyName("v_l1n")]
        public double VL1N { get; set; }

        [JsonPropertyName("real_power_a")]
        public long RealPowerA { get; set; }

        [JsonPropertyName("reactive_power_a")]
        public long ReactivePowerA { get; set; }

        [JsonPropertyName("serial_number")]
        public string SerialNumber { get; set; }

        [JsonPropertyName("timeout")]
        public long Timeout { get; set; }
    }

    public class Connection
    {
        [JsonPropertyName("short_id")]
        public string ShortId { get; set; }

        [JsonPropertyName("device_serial")]
        public string DeviceSerial { get; set; }

        [JsonPropertyName("https_conf")]
        public HttpsConf HttpsConf { get; set; }
    }

    public class HttpsConf { }
    
        
    public class AggregateBase
    {
        [JsonPropertyName("last_communication_time")]
        public DateTime LastCommunicationTime { get; set; }
        
        [JsonPropertyName("instant_power")]
        public double InstantPower { get; set; }
        
        [JsonPropertyName("Instant_reactive_Power")]
        public double InstantReactivePower { get; set; }
        
        [JsonPropertyName("instant_apparent_power")]
        public double InstantApparentPower { get; set; }
        
        [JsonPropertyName("frequency")]
        public double Frequency { get; set; }
        
        [JsonPropertyName("energy_exported")]
        public double EnergyExported { get; set; }
        
        [JsonPropertyName("energy_imported")]
        public double EnergyImported { get; set; }
        
        [JsonPropertyName("instant_average_voltage")]
        public double InstantAverageVoltage { get; set; }
        
        [JsonPropertyName("instant_total_current")]
        public double InstantTotalCurrent { get; set; }
        
        [JsonPropertyName("i_a_current")]
        public double IACurrent { get; set; }
        
        [JsonPropertyName("i_b_current")]
        public double IBCurrent { get; set; }

        [JsonPropertyName("i_c_current")]
        public double ICCurrent { get; set; }
        
        [JsonPropertyName("timeout")]
        public double Timeout { get; set; }
    }

    public class InformationBase
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("cts")]
        public bool[] Cts { get; set; }

        [JsonPropertyName("inverted")]
        public bool[] Inverted { get; set; }

        [JsonPropertyName("connection")]
        public Connection Connection { get; set; }

        [JsonPropertyName("Cached_readings")]
        public CachedReadings CachedReadings { get; set; }
    }
}