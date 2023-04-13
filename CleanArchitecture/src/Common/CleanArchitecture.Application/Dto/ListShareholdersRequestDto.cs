using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
    public class ListShareholdersRequestDto
    {
        public string SearchField { get; set; }
        public string Filter { get; set; }
        public string FilterValue { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}