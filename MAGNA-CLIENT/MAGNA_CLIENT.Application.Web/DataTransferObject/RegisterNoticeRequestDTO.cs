using System;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject
{
    public class RegisterNoticeRequestDTO
    {
        public Guid Id { get; set; }
        public string NoticeCode { get; set; }
        public string NoticeDescription { get; set; }
        public DateTime NoticeDate { get; set; }
        public string NoticeState { get; set; }
        public string NoticePriority { get; set; }
    }
}
