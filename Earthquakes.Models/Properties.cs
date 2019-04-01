using Earthquakes.Models.Utils;
using Newtonsoft.Json;
using System;

namespace Earthquakes.Models
{
    public class Properties
    {
        [JsonProperty("mag")]
        public double Mag { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }

        [JsonProperty("time")]
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime Time { get; set; }
       
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
