using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
    public class InterestPaymentDto
    {
        public List<InterestDate> InterestDate { get; set; }
        public List<InterestPaymentResponse> InterestPayment { get; set; }
    }

    public class InterestDate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
    }

    public class InterestPaymentResponse
    {
        public int Id { get; set; }
        public string OfferPeriod { get; set; }
        public decimal Microloans { get; set; }
        public decimal PrevInterestRate { get; set; }
        public decimal NewInterestRate { get; set; }
        public decimal InterestPayment1 { get; set; }
        public decimal InterestPayment2 { get; set; }
        public decimal InterestPayment3 { get; set; }
    }
}