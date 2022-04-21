using System;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject.Notice
{
    public class RegisterNoticeStateRequestDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string NoticeStateCode { get; set; }
        [Required]
        public string NoticeStateDescription { get; set; }
    }
}
