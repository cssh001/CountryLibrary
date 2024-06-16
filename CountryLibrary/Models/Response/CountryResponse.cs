using System.Text.Json.Serialization;

namespace CountryLibrary.Models.Response
{
    public class CountryInfoListResponse
    {
        [JsonPropertyName("CountryInfos")]
        public required List<CountryInfo> CountryInfos { get; set; }
    }
    public class CountryInfoResponse
    {
        [JsonPropertyName("CountryInfo")]
        public required CountryInfo CountryInfo { get; set; }
    }
    public class CountryInfo
    {
        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        [JsonPropertyName("Alpha2Code")]
        public string? Alpha2Code { get; set; }

        [JsonPropertyName("Capital")]
        public string? Capital { get; set; }

        [JsonPropertyName("CallingCodes")]
        public int? CallingCodes { get; set; }

        [JsonPropertyName("FlagUrl")]
        public string? FlagUrl { get; set; }

        [JsonPropertyName("Timezones")]
        public string? Timezones { get; set; }
    }
}
