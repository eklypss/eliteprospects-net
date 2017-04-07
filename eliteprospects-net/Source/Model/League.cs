using Newtonsoft.Json;

namespace eliteprospects_net.Source.Model
{
    public class League
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "playerLevel")]
        public string PlayerLevel { get; set; }

        [JsonProperty(PropertyName = "@virtual")]
        public string Virtual { get; set; }

        [JsonProperty(PropertyName = "gameType")]
        public string GameType { get; set; }

        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }

        [JsonProperty(PropertyName = "hideParentLeagueName")]
        public string HideParentLeagueName { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageURL { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "hasChildLeagues")]
        public string HasChildLeagues { get; set; }

        [JsonProperty(PropertyName = "teamType")]
        public string TeamType { get; set; }

        [JsonProperty(PropertyName = "teamClass")]
        public string TeamClass { get; set; }

        [JsonProperty(PropertyName = "searchable")]
        public string Searchable { get; set; }

        [JsonProperty(PropertyName = "country")]
        public Country Country { get; set; }
    }
}