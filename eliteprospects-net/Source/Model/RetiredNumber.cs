using Newtonsoft.Json;
using System.Collections.Generic;

namespace eliteprospects_net.Source.Model
{
    public class RetiredNumber
    {
        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<Data> DataList { get; set; }
    }
}