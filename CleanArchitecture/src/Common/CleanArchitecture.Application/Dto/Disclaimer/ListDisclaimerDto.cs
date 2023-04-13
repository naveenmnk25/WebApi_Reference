using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
	public class ListDisclaimerDto
	{
        public List<DisclaimerDto> Disclaimer { get; }
    }

    public class DisclaimerDto
    {
        public int DisclaimerId { get; set; }
        public int DisclaimerType { get; set; }
        public string Content { get; set; }
        public DateTime DisclaimerOn { get; set; }
        public bool IsActive { get; set; }
    }
}