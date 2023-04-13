using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
    public class ListUploadReferenceDto
    {
        public List<UploadReferences> UploadReferences { get; }
    }

    public class UploadReferences
    {
        public int UploadReferenceId { get; set; }
        public string FilesName { get; set; }
        public string FilesType { get; set; }
        public int NoOfRecords { get; set; }
        public string UploadedBy { get; set; }
    }
}