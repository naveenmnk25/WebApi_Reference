using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
    public class ReportShareholdersByOfferPeriodDto
    {
        public List<ShareholdersByOfferPeriod> Shareholders { get; }
    }

    public class ShareholdersByOfferPeriod
    {
        public int RowNo { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string OfferPeriod { get; set; }
        public decimal Microloans { get; set; }
        public decimal NoOfShares { get; set; }
        public bool IsActive { get; set; }
        public decimal Percents { get; set; }
    }
}