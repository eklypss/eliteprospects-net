using Newtonsoft.Json;

namespace eliteprospects_net.Source.Model
{
    public class Data
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        public Player Player { get; set; }

        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }

        [JsonProperty(PropertyName = "numbers")]
        public int Number { get; set; }

        public Team Team { get; set; }
    }
}