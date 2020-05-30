namespace GatewayClient.Models
{
    using System;
    using System.Text.Json.Serialization;

    public class PowerwallInformation
    {
        [JsonPropertyName("enumerating")]
        public bool Enumerating { get; set; }

        [JsonPropertyName("updating")]
        public bool Updating { get; set; }

        [JsonPropertyName("checking_if_offgrid")]
        public bool CheckingIfOffgrid { get; set; }

        [JsonPropertyName("running_phase_detection")]
        public bool RunningPhaseDetection { get; set; }

        [JsonPropertyName("phase_detection_last_error")]
        public string PhaseDetectionLastError { get; set; }

        [JsonPropertyName("bubble_shedding")]
        public bool BubbleShedding { get; set; }

        [JsonPropertyName("on_grid_check_error")]
        public string OnGridCheckError { get; set; }

        [JsonPropertyName("grid_qualifying")]
        public bool GridQualifying { get; set; }

        [JsonPropertyName("grid_code_validating")]
        public bool GridCodeValidating { get; set; }

        [JsonPropertyName("phase_detection_not_available")]
        public bool PhaseDetectionNotAvailable { get; set; }

        [JsonPropertyName("powerwalls")]
        public Powerwall[] Powerwalls { get; set; }

        [JsonPropertyName("has_sync")]
        public bool HasSync { get; set; }

        [JsonPropertyName("sync")]
        public Sync Sync { get; set; }

        [JsonPropertyName("states")]
        public object[] States { get; set; }
    }

    public class Powerwall
    {
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("PackagePartNumber")]
        public string PackagePartNumber { get; set; }

        [JsonPropertyName("PackageSerialNumber")]
        public string PackageSerialNumber { get; set; }

        [JsonPropertyName("type")]
        public string PowerwallType { get; set; }

        [JsonPropertyName("phase")]
        public string Phase { get; set; }

        [JsonPropertyName("grid_state")]
        public string GridState { get; set; }

        [JsonPropertyName("grid_reconnection_time_seconds")]
        public long GridReconnectionTimeSeconds { get; set; }

        [JsonPropertyName("under_phase_detection")]
        public bool UnderPhaseDetection { get; set; }

        [JsonPropertyName("updating")]
        public bool Updating { get; set; }

        [JsonPropertyName("commissioning_diagnostic")]
        public Diagnostic CommissioningDiagnostic { get; set; }

        [JsonPropertyName("update_diagnostic")]
        public Diagnostic UpdateDiagnostic { get; set; }

        [JsonPropertyName("bc_type")]
        public string BcType { get; set; }
    }

    public class Diagnostic
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("disruptive")]
        public bool Disruptive { get; set; }

        [JsonPropertyName("inputs")]
        public object Inputs { get; set; }

        [JsonPropertyName("checks")]
        public Check[] Checks { get; set; }
    }

    public class Check
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("start_time")]
        public DateTimeOffset? StartTime { get; set; }

        [JsonPropertyName("end_time")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("results")]
        public Debug Results { get; set; }

        [JsonPropertyName("debug")]
        public Debug Debug { get; set; }

        [JsonPropertyName("progress")]
        public long? Progress { get; set; }
    }

    public class Debug { }

    public class Sync
    {
        [JsonPropertyName("updating")]
        public bool Updating { get; set; }

        [JsonPropertyName("commissioning_diagnostic")]
        public Diagnostic CommissioningDiagnostic { get; set; }

        [JsonPropertyName("update_diagnostic")]
        public Diagnostic UpdateDiagnostic { get; set; }
    }

    public enum Status { Fail, NotRun };
}