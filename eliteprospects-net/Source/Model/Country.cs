using Newtonsoft.Json;

namespace eliteprospects_net
{
    public class Country
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty(PropertyName = "shortName")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "iso3166_2")]
        public string ISO31662 { get; set; }

        [JsonProperty(PropertyName = "iso3166_3")]
        public string ISO31663 { get; set; }
    }
}