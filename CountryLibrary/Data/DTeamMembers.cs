using CountryLibrary.Models.Response;

namespace CountryLibrary.Data
{
    public class DTeamMembers
    {
        public List<TeamInfo> DTeamMemberList()
        {
            var teamMembers = new List<TeamInfo>()
            {
                new TeamInfo
                {
                    Name = "Senghong",
                    Gender = "Male",
                    Age = 22,
                    Address = "KPC",
                    Email = "senghong.hang@techbodia.com",
                },
                new TeamInfo
                {
                    Name = "So Vannak",
                    Gender = "Male",
                    Age = 22,
                    Address = "Svay Reang",
                    Email = "vannak.rith@techbodia.com",
                },
                 new TeamInfo
                {
                    Name = "Darany",
                    Gender = "Male",
                    Age = 19,
                    Address = "Prey Veng",
                    Email = "darany.brak@techbodia.com",
                },
            };

            return teamMembers;
        }
    }
}
