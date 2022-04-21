using System;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject.Notice
{
    public class RegisterNoticeTypeRequestDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string NoticeTypeCode { get; set; }
        [Required]
        public string NoticeTypeDescription { get; set; }
    }
}
