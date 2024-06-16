using CountryLibrary.Data;
using CountryLibrary.Models.Response;

namespace CountryLibrary.Services
{
    public class TeamMemberService:ITeamMemberServicecs
    {
        private DTeamMembers _teamMembers = new DTeamMembers();

        public TeamMemberResponse GetTeamMembers()
        {
            var data = new TeamMemberResponse {  TeamMembers = _teamMembers.DTeamMemberList() };
         
            return data;
        }
    }
}
