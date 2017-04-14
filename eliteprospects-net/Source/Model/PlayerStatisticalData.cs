using Newtonsoft.Json;

namespace eliteprospects_net
{
    public class PlayerStatisticalData
    {
        [JsonProperty(PropertyName = "nullheight")]
        public Height Height { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public Weight Weight { get; set; }
    }
}