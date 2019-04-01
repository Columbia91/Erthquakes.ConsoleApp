using Newtonsoft.Json;

namespace Earthquakes.Models
{
    public class Feature
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }
}
