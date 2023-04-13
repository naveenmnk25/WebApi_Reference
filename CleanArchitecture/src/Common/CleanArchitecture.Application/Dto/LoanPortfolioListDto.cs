
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Application.Dto
{
    public class LoanPortfolioListDto
    {
        public string TotalShare { get; set; }
        public string TotalOutstanding { get; set; }
        public List<LoanPortfolioDto> MicroLoans { get; }
    }

    public sealed class LoanPortfolioDto
    {
        public int LoanPortfolioId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public int OfferPeriodId { get; set; }
        public decimal Microloans { get; set; }
        public decimal NoOfShares { get; set; }
        public string OfferPeriod { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public DateTime PaidDate { get; set; }
    }
}