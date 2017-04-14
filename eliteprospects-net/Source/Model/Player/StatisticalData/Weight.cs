using Newtonsoft.Json;

namespace eliteprospects_net
{
    public class Weight
    {
        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "min")]
        public int Min { get; set; }

        [JsonProperty(PropertyName = "max")]
        public int Max { get; set; }

        [JsonProperty(PropertyName = "avg")]
        public double Average { get; set; }

        [JsonProperty(PropertyName = "variance")]
        public double Variance { get; set; }

        [JsonProperty(PropertyName = "stdDeviation")]
        public double StandardDeviation { get; set; }

        [JsonProperty(PropertyName = "sumOfSquares")]
        public int SumOfSquares { get; set; }
    }
}