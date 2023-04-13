using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
	public class ListReminderDto
	{
        public List<ReminderDto> Reminder { get; }
    }

    public class ReminderDto
    {
        public int ReminderId { get; set; }
        public string Name { get; set; }
        public string ReminderText { get; set; }
        public string EmailIds { get; set; }
        public DateTime ReminderOn { get; set; }
        public int ReminderType { get; set; }
        public int ReminderStatus { get; set; }
    }
}