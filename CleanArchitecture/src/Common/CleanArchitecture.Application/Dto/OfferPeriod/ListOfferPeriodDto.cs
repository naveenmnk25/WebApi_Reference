using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
    public class ListOfferPeriodDto
	{
        public List<OfferPeriodDto> OfferPeriod { get; }
    }

    public class OfferPeriodDto
    {
        public int OfferPeriodId { get; set; }
        public string Name { get; set; }
        public int? OfferPeriodMonth { get; set; }
        public int? OfferPeriodYear { get; set; }
        public int InterestPeriodId { get; set; }
        public DateTime? DueDate { get; set; }
    }
}