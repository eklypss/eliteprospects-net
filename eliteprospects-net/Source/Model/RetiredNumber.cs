using Newtonsoft.Json;
using System.Collections.Generic;

namespace eliteprospects_net
{
    public class RetiredNumber
    {
        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<Data> DataList { get; set; }

        public class Data
        {
            [JsonProperty(PropertyName = "id")]
            public int ID { get; set; }

            public Player Player { get; set; }

            [JsonProperty(PropertyName = "updated")]
            public string Updated { get; set; }

            [JsonProperty(PropertyName = "number")]
            public int Number { get; set; }

            public Team Team { get; set; }
        }
    }
}