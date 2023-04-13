using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
    public class InterestPaymentBalanceDto
    {
        public InterestPaymentAbstract InterestPaymentAbstract { get; set; }
        public List<InterestPaymentBalanceResponse> InterestPaymentBalance { get; set; }
    }

    public class InterestPaymentAbstract
    {
        public string CaptionTitle { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal Total { get; set; }
        public decimal Paid { get; set; }
        public decimal PendingInterest { get; set; }
        public decimal Balace { get; set; }
    }

    public class InterestPaymentBalanceResponse
    {
        public int Id { get; set; }
        public string OfferPeriod { get; set; }
        public decimal Microloans { get; set; }
        public decimal PrevInterestRate { get; set; }
        public decimal NewInterestRate { get; set; }
        public decimal InterestAmount { get; set; }
    }
}