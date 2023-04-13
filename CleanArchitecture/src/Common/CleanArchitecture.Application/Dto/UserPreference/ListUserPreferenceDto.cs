using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
	public class ListUserPreferenceDto
	{
        public List<UserPreferenceDto> UserPreference { get; }
    }

    public class UserPreferenceDto
    {
        public int UserPreferenceId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Message { get; set; }
        public string Reply { get; set; }
        public int Status { get; set; }
    }
}