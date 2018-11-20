using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FunctionApp1
{
    public class PerformanceTask
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("plannedStartTime")]
        public TimeSpan? PlannedStartTime { get; set; }

        [JsonProperty("plannedEndTime")]
        public TimeSpan? PlannedEndTime { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("taskInfo")]
        public string TaskInfo { get; set; }

        [JsonProperty("diagramNumber")]
        public string DiagramNumber { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("locationFrom")]
        public string LocationFrom { get; set; }

        [JsonProperty("locationTo")]
        public string LocationTo { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("trainComposed")]
        public string TrainComposed { get; set; }

        [JsonProperty("referencedPerformance")]
        public string ReferencedPerformance { get; set; }

        [JsonProperty("trainNumberFunctional")]
        public string TrainNumberFunctional { get; set; }

        [JsonProperty("contactInformation")]
        public List<ContactInformation> ContactInformation { get; set; }

        [JsonProperty("driveDetails")]
        public List<DriveDetail> DriveDetails { get; set; }

        [JsonProperty("taskMaterials")]
        public List<TaskMaterial> TaskMaterials { get; set; }
    }
}