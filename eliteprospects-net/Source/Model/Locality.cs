using Newtonsoft.Json;

namespace eliteprospects_net
{
    public class Locality
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "localityType")]
        public string LocalityType { get; set; }

        [JsonProperty(PropertyName = "country")]
        public Country Country { get; set; }
    }
}