using Newtonsoft.Json;
using System.Collections.Generic;

namespace eliteprospects_net
{
    public class Transfer
    {
        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<Data> DataList { get; set; }

        public class Data
        {
            [JsonProperty(PropertyName = "id")]
            public int ID { get; set; }

            [JsonProperty(PropertyName = "fromTeam")]
            public Team FromTeam { get; set; }

            [JsonProperty(PropertyName = "toTeam")]
            public Team ToTeam { get; set; }

            [JsonProperty(PropertyName = "player")]
            public Player Player { get; set; }

            [JsonProperty(PropertyName = "transferDate")]
            public string Updated { get; set; }

            [JsonProperty(PropertyName = "transferType")]
            public string TransferDate { get; set; }

            [JsonProperty(PropertyName = "updated")]
            public string TransferType { get; set; }

            [JsonProperty(PropertyName = "transferProbability")]
            public string TransferProbability { get; set; }

            [JsonProperty(PropertyName = "transferSources")]
            public List<TransferSource> TransferSources { get; set; }
        }
    }
}