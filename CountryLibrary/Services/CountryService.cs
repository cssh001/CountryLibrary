using CountryLibrary.Models.Request;
using CountryLibrary.Models.Response;
using System.Text.Json;

namespace CountryLibrary.Services
{
    public class CountryService : ICountryService
    {
        private HttpClient _httpClient = new HttpClient();

        public async Task<CountryInfoResponse> GetCountryByName(CountryNameRequest request)
        {
            if (string.IsNullOrEmpty(request.CountryName))
            {
                throw new Exception("Please input parameter values");
            }

            string url = $"https://restcountries.com/v3.1/name/{Uri.EscapeDataString(request.CountryName)}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();

                var country = JsonSerializer.Deserialize<List<CountryCallBackReponse>>(responseData).FirstOrDefault();

                if (country != null)
                {
                    CountryInfo countryInfo = new CountryInfo();

                    countryInfo.Name = country.name.common;
                    countryInfo.Capital = country.capital.FirstOrDefault() ?? "";
                    countryInfo.Timezones = country?.timezones.FirstOrDefault() ?? "";
                    countryInfo.FlagUrl = country?.flags.png ?? "";
                    countryInfo.Alpha2Code = country?.cca2 ?? "";
                    countryInfo.CallingCodes = int.Parse(country?.idd.root + country?.idd.suffixes.FirstOrDefault());

                    var countryByName = new CountryInfoResponse { CountryInfo = countryInfo };

                    return countryByName;
                }
                throw new Exception("The data is null");
            }
            else
            {
                throw new Exception($"API call failed with status code: {response.StatusCode}");
            }
        }

        public async Task<CountryInfoListResponse> GetCountryByArea(CountryAreaRequest area)
        {
            string region = area.Region;
            string timeZone = area.Timezones;

            if (string.IsNullOrEmpty(region) || string.IsNullOrEmpty(timeZone)) {

                throw new Exception("Please input parameter values");  
            }

            string url = $"https://restcountries.com/v3.1/all";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();

                var countries = JsonSerializer.Deserialize<List<CountryCallBackReponse>>(responseData);

                if (countries != null)
                {
                    List<CountryInfo> countryInfoList = new List<CountryInfo>();

                        foreach (var country in countries)
                        {
                            CountryInfo countryInfo = new CountryInfo();

                            if (country.region == region && country.timezones.FirstOrDefault() == timeZone)
                            {
                                countryInfo.Name = country.name.common;
                                countryInfo.Capital = country.capital.FirstOrDefault() ?? "";
                                countryInfo.Timezones = country.timezones.FirstOrDefault() ?? "";
                                countryInfo.FlagUrl = country?.flags.png ?? "";
                                countryInfo.Alpha2Code = country?.cca2 ?? "";
                                countryInfo.CallingCodes = int.Parse(country?.idd.root + country?.idd.suffixes[0]);

                                countryInfoList.Add(countryInfo);
                            }
                        }
                        
                    var countyList = new CountryInfoListResponse { CountryInfos = countryInfoList };

                    return countyList;
                }

                throw new Exception("Not found data");
            }
            else
            {
                throw new Exception($"API call failed with status code: {response.StatusCode}");
            }
        }
    }
}
