using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Application.Dto
{
    public class ListShareholdersDto
    {
        public List<ShareholderDto> Shareholders { get; set; }
        public int RecordCount { get; }
    }

    public class ShareholderDto
    {
        public int RowNo { get; set; }
        public bool IsActive { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Microloans { get; set; }
        public decimal NoOfShares { get; set; }
        public int RowsCount { get; set; }
    }
}