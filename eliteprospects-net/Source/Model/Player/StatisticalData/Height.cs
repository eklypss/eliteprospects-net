using Newtonsoft.Json;

namespace eliteprospects_net
{
    public class Height
    {
        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "min")]
        public string Min { get; set; }

        [JsonProperty(PropertyName = "max")]
        public string Max { get; set; }

        [JsonProperty(PropertyName = "avg")]
        public string Average { get; set; }

        [JsonProperty(PropertyName = "variance")]
        public string Variance { get; set; }

        [JsonProperty(PropertyName = "stdDeviation")]
        public string StandardDeviation { get; set; }

        [JsonProperty(PropertyName = "sumOfSquares")]
        public int SumOfSquares { get; set; }
    }
}