using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
	public class ListSettingsDto
	{
        public List<SettingsDto> Settings { get; }
    }

    public class SettingsDto
    {
        public int SettingsId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}