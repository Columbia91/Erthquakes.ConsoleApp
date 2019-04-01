using Newtonsoft.Json;

namespace Earthquakes.Models
{
    public class Metadata
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
