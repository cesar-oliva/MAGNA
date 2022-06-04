using System;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject
{
    public class RegisterNoticeRequestDTO
    {
        public Guid Id { get; set; }
        public string NoticeCode { get; set; }
        public string NoticeDescription { get; set; }
        public Guid NoticeTypeId { get; set; }
        public DateTime NoticeDate { get; set; }
        public Guid NoticeStateId { get; set; }
        public Guid NoticePriorityId { get; set; }
        public string FaultType { get; set; }
        public Guid TechnicalLocationId { get; set; }
        public string AffectedPart { get; set; }
        public string FaultDescription { get; set; }
        public Guid NoticeCategoryId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid AssembleId { get; set; }
    }
}



