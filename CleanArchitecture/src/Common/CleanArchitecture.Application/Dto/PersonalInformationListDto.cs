using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
    public class PersonalInformationListDto
    {
        public List<PersonalInformationDto> ListResponse { get; }
    }

    public sealed class PersonalInformationDto
    {
        public int PersonalInformationId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string DPBankName { get; set; }
        public string VPBankName { get; set; }
        public string DPDematNumber { get; set; }
        public string VPDematNumber { get; set; }
        public string Email { get; set; }
        public string TelePhone { get; set; }
        public string TelePhone2 { get; set; }
        public string TransBankName { get; set; }
        public string TransAccountNumber { get; set; }
    }
}