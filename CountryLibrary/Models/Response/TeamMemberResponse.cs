using System.Text.Json.Serialization;

namespace CountryLibrary.Models.Response
{
    public class TeamMemberResponse
    {
       [JsonPropertyName("TeamMembers")]
       public required List<TeamInfo> TeamMembers { get; set; }
    }

    public class TeamInfo
    {
        [JsonPropertyName("Name")]
        public required string Name { get; set; }

        [JsonPropertyName("Gender")]
        public required string Gender { get; set; }

        [JsonPropertyName("Age")]
        public required int Age { get; set; }

        [JsonPropertyName("Address")]
        public required string Address { get; set; }

        [JsonPropertyName("Email")]
        public required string Email { get; set; }
    }
}
