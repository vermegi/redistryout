using Newtonsoft.Json;

namespace FunctionApp2
{
    public class TaskMaterial
    {
        [JsonProperty("diagramNumber")]
        public string DiagramNumber { get; set; }

        [JsonProperty("materialType")]
        public string MaterialType { get; set; }
    }
}