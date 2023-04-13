using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
	public class ListCommentDto
	{
        public List<CommentDto> Comment { get; }
    }

    public class CommentDto
    {
        public int CommentId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Message { get; set; }
        public string Reply { get; set; }
        public int Status { get; set; }
    }
}