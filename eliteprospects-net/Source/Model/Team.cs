using Newtonsoft.Json;

namespace eliteprospects_net.Source.Model
{
    public class Team
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "inactive")]
        public string Inactive { get; set; }

        [JsonProperty(PropertyName = "editorialNotes")]
        public string EditorialNotes { get; set; }

        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageURL { get; set; }

        [JsonProperty(PropertyName = "foundedYear")]
        public int FoundedYear { get; set; }

        [JsonProperty(PropertyName = "colors")]
        public string Colors { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "teamClass")]
        public string TeamClass { get; set; }

        [JsonProperty(PropertyName = "teamType")]
        public string TeamType { get; set; }

        [JsonProperty(PropertyName = "searchable")]
        public string Searchable { get; set; }
    }
}