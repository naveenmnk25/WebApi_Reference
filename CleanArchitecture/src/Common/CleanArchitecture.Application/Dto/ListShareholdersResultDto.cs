using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
    public class ListShareholdersResultDto
    {
        public List<Shareholder> Shareholders { get; set; }
    }

    public class Shareholder
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