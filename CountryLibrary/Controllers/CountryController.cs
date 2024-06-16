using CountryLibrary.Models.Request;
using CountryLibrary.Services;
using Microsoft.AspNetCore.Mvc;

namespace CountryLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController(ICountryService countryService):ControllerBase
    {
        private readonly ICountryService _countryServince = countryService;
    
        [HttpPost("GetCountryByName")]
        public async Task<IActionResult> GetCountryByName([FromBody] CountryNameRequest request)
        {
            var country = await _countryServince.GetCountryByName(request);

            return Ok(country);
        }

        [HttpPost("GetCountryByArea")]
        public async Task<IActionResult> GetCountryByArea([FromBody] CountryAreaRequest request)
        {
            var countries = await _countryServince.GetCountryByArea(request);

            return Ok(countries);
        }
    }
}
