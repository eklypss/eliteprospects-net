using Newtonsoft.Json;

namespace eliteprospects_net.Source.Model
{
    public class Player
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "yearofBirth")]
        public int YearOfBirth { get; set; }

        [JsonProperty(PropertyName = "dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty(PropertyName = "playerGameStatus")]
        public string GameStatus { get; set; }

        [JsonProperty(PropertyName = "playerPosition")]
        public string Position { get; set; }

        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "height")]
        public string Height { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public string Weight { get; set; }

        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }

        [JsonProperty(PropertyName = "Shoots")]
        public string Shoots { get; set; }

        [JsonProperty(PropertyName = "playerStatus")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "country")]
        public Country Country { get; set; }
    }
}