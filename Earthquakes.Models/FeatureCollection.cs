using System.Collections.Generic;
using Newtonsoft.Json;

namespace Earthquakes.Models
{
    public class FeatureCollection
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("features")]
        public List<Feature> Features { get; set; }
    }
}
