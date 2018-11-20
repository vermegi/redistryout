using Newtonsoft.Json;

namespace FunctionApp1
{
    public class TaskMaterial
    {
        [JsonProperty("diagramNumber")]
        public string DiagramNumber { get; set; }

        [JsonProperty("materialType")]
        public string MaterialType { get; set; }
    }
}