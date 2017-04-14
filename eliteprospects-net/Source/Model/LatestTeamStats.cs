using Newtonsoft.Json;

namespace eliteprospects_net
{
    public class LatestTeamStats
    {
        [JsonProperty(PropertyName = "champion")]
        public string Champion { get; set; }

        [JsonProperty(PropertyName = "position")]
        public int Position { get; set; }

        [JsonProperty(PropertyName = "GF")]
        public int GoalsFor { get; set; }

        [JsonProperty(PropertyName = "GA")]
        public int GoalsAgainst { get; set; }

        [JsonProperty(PropertyName = "OTL")]
        public int OvertimeLosses { get; set; }

        [JsonProperty(PropertyName = "postseason")]
        public string PostSeason { get; set; }

        [JsonProperty(PropertyName = "L")]
        public int Losses { get; set; }

        [JsonProperty(PropertyName = "team")]
        public Team Team { get; set; }

        [JsonProperty(PropertyName = "league")]
        public League League { get; set; }

        [JsonProperty(PropertyName = "TP")]
        public int TotalPoints { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "W")]
        public int Wins { get; set; }

        [JsonProperty(PropertyName = "season")]
        public Season Season { get; set; }

        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }

        [JsonProperty(PropertyName = "GP")]
        public int GamesPlayed { get; set; }

        [JsonProperty(PropertyName = "OTW")]
        public int OvertimeWins { get; set; }
    }
}