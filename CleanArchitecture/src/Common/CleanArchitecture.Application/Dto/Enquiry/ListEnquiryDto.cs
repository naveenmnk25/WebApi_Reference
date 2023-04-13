using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
	public class ListEnquiryDto
	{
        public List<EnquiryDto> Enquiry { get; }
    }

    public class EnquiryDto
    {
        public int EnquiryId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Message { get; set; }
        public string Reply { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}