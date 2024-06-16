using System.Text.Json.Serialization;

namespace CountryLibrary.Models.Request
{
    public class CountryNameRequest
    {
        [JsonPropertyName("CountryName")]
        public required string CountryName { get; set; }
    }

    public class CountryAreaRequest
    {
        [JsonPropertyName("Region")]
        public required string Region { get; set; }

        [JsonPropertyName("Timezones")]
        public required string Timezones { get; set; }

    }
}
