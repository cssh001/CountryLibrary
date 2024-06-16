using CountryLibrary.Services;
using Microsoft.AspNetCore.Mvc;

namespace CountryLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController(ITeamMemberServicecs teamMemberServicecs) : ControllerBase
    {
        private readonly ITeamMemberServicecs _teamMemberServicecs = teamMemberServicecs;

        [HttpGet("GetTeamMembers")]
        public IActionResult GetTeamMembers()
        {
            var data = _teamMemberServicecs.GetTeamMembers();
            return Ok(data);
        }
    }
}
