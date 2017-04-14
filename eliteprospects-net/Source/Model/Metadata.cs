using Newtonsoft.Json;

namespace eliteprospects_net
{
    public class Metadata
    {
        [JsonProperty(PropertyName = "limit")]
        public int Limit { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }
    }
}