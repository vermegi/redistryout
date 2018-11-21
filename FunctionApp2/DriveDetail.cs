using Newtonsoft.Json;
using System;

namespace FunctionApp2
{
    public class DriveDetail
    {
        [JsonProperty("arrivalTime")]
        public TimeSpan? ArrivalTime { get; set; }

        [JsonProperty("passTroughTime")]
        public TimeSpan? PassTroughTime { get; set; }

        [JsonProperty("departureTime")]
        public TimeSpan? DepartureTime { get; set; }

        [JsonProperty("locationNl")]
        public string LocationNl { get; set; }

        [JsonProperty("locationFr")]
        public string LocationFr { get; set; }

        [JsonProperty("locationCode")]
        public string LocationCode { get; set; }

        [JsonProperty("lineInfo")]
        public string LineInfo { get; set; }

        [JsonProperty("lineNumber")]
        public string LineNumber { get; set; }

        [JsonProperty("isBnx")]
        public bool IsBnx { get; set; }

        [JsonProperty("isExtraStop")]
        public bool IsExtraStop { get; set; }

        [JsonProperty("alarmNumber")]
        public string AlarmNumber { get; set; }

        [JsonProperty("ptcarId")]
        public string PtcarId { get; set; }

        [JsonProperty("ptcarlatitude")]
        public double PtcarLatitude { get; set; }

        [JsonProperty("ptcarlongitude")]
        public double PtcarLongitude { get; set; }
    }
}