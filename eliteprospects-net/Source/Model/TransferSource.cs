using Newtonsoft.Json;

namespace eliteprospects_net
{
    public class TransferSource
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }
    }
}