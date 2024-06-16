using CountryLibrary.Models;
using CountryLibrary.Models.Request;
using CountryLibrary.Models.Response;

namespace CountryLibrary.Services
{
    public interface ICountryService
    {
        Task<CountryInfoResponse> GetCountryByName(CountryNameRequest country);
        Task<CountryInfoListResponse> GetCountryByArea(CountryAreaRequest area);
    }

}
