using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
	public class ListInterestPeriodDto
	{
        public List<InterestPeriodDto> InterestPeriod { get; }
    }

    public class InterestPeriodDto
    {
        public int InterestPeriodId { get; set; }
        public string Name { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? NewInterestRate { get; set; }
        public DateTime? DueDate { get; set; }
    }
}