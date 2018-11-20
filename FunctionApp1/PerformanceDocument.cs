using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp1
{
    public class PerformanceDocument : ICloneable
    {
        #region Mapped

        [JsonProperty("activeDate")]
        public DateTime ActiveDate { get; set; }

        // TODO make multi language object
        [JsonProperty("activeFr")]
        public string ActiveFr { get; set; }

        // TODO make multi language object
        [JsonProperty("activeNl")]
        public string ActiveNl { get; set; }

        [JsonProperty("backendKey")]
        public string BackendKey { get; set; }

        [JsonProperty("plannedStartTime")]
        public TimeSpan? PlannedStartTime { get; set; }

        [JsonProperty("beginHourSleepLoc")]
        public string BeginHourSleepLoc { get; set; }

        [JsonProperty("idfNumber")]
        public string IdfNumber { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("performanceDate")]
        public DateTime PerformanceDate { get; set; }

        [JsonProperty("depotNumber")]
        public string DepotNumber { get; set; }

        [JsonProperty("plannedEndTime")]
        public TimeSpan? PlannedEndTime { get; set; }

        [JsonProperty("endHourSleepLoc")]
        public string EndHourSleepLoc { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("firstOperation")]
        public string FirstOperation { get; set; }

        [JsonProperty("firstTrain")]
        public string FirstTrain { get; set; }

        [JsonProperty("lastModified")]
        public DateTimeOffset LastModified { get; set; }

        [JsonProperty("midnightCross")]
        public string MidnightCross { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("performanceNumber")]
        public string PerformanceNumber { get; set; }

        [JsonProperty("opalVersionNumber")]
        public string OpalVersionNumber { get; set; }

        [JsonProperty("organisationBackendKey")]
        public string OrganisationBackendKey { get; set; }

        [JsonProperty("personRemark")]
        public string PersonRemark { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("sequence")]
        public string Sequence { get; set; }

        [JsonProperty("serName")]
        public string SerName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("userVersionNumber")]
        public string UserVersionNumber { get; set; }

        [JsonProperty("versionNumber")]
        public string VersionNumber { get; set; }

        [JsonProperty("performanceId")]
        public string PerformanceId { get; set; }

        [JsonProperty("duration")]
        public TimeSpan Duration { get; set; }

        #endregion

        #region Relational

        // Tasks
        [JsonProperty("tasks")]
        public List<PerformanceTask> Tasks { get; set; }

        // Profile
        [JsonProperty("personBk")]
        public string PersonBk { get; set; }

        // TctDepot
        [JsonProperty("tctId")]
        public string TctId { get; set; }

        [JsonProperty("tctNameNl")]
        public string TctNameNl { get; set; }

        [JsonProperty("tctNameFr")]
        public string TctNameFr { get; set; }

        [JsonProperty("symbolicNameDepot")]
        public string SymbolicNameDepot { get; set; }

        #endregion

        #region System

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }
        #endregion

        #region Calculated fields

        [JsonProperty("plannedStartDateTime")]
        public DateTimeOffset? PlannedStartDateTime { get; set; }

        [JsonProperty("plannedEndDateTime")]
        public DateTimeOffset? PlannedEndDateTime { get; set; }

        #endregion


        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
