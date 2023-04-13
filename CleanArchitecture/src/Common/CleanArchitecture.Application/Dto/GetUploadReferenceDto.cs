namespace CleanArchitecture.Application.Dto
{
    public class GetUploadReferenceDto
    {
        public GetUploadReferenceDto()
        {

        }
        public int Id { get; set; }
        public string fileName { get; set; }
        public string fileType { get; set; }
    }
}
