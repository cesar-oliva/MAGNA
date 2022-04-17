using System;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    public class RegisterNoticeRequestDTO
    {
        public Guid Id { get; set; }
        public string NoticeCode { get; set; }
        public string NoticeDescription { get; set; }
        public DateTime NoticeDate { get; set; }
        public string EmployeeCode { get; set; }
        public string NoticeState { get; set; }
        public string NoticeCategory { get; set; }
        public string NoticePriority { get; set; }
        public string AssambleDescription { get; set; }
        public string FaultType { get; set; }
        public string TechnicalLocation { get; set; }
        public string AffectedPart { get; set; }
        public string FaultDescription { get; set; }
    }
}



