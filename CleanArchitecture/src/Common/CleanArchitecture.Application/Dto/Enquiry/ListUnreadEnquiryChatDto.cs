﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Application.Dto
{
    public class ListUnreadEnquiryChatDto
    {
        public List<UnreadEnquiryChatDto> EnquiryChat { get; }
        public RecordCount RecordCount { get; }
    }

    public class UnreadEnquiryChatDto
    {
        public int EnquiryId { get; set; }
        public string Name { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Message { get; set; }
        public string Reply { get; set; }
        public string Status { get; set; }
        public DateTime EnquiryOn { get; set; }
        public DateTime LastUpdateOn { get; set; }
    }
}