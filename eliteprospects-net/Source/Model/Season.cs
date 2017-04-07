using Newtonsoft.Json;

namespace eliteprospects_net.Source.Model
{
    public class Season
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "endYear")]
        public int EndYear { get; set; }

        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }

        [JsonProperty(PropertyName = "startYear")]
        public int StartYear { get; set; }

        [JsonProperty(PropertyName = "seasonTypeStart")]
        public string SeasonTypeStart { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "active")]
        public string Active { get; set; }

        [JsonProperty(PropertyName = "seasonTypeEnd")]
        public string SeasonTypeEnd { get; set; }
    }
}