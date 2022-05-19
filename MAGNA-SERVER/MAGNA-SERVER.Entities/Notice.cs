using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    [Table("Notice")]
    public class Notice : Entity
    {
        public string NoticeCode { get; set; }
        public string NoticeDescription { get; set; }
        public DateTime NoticeDate { get; set; }
        public string FaultType { get; set; }
        public string AffectedPart { get; set; }
        public string FaultDescription { get; set; }

        //llave foranea
        public Guid NoticeCategoryId { get; set; }
        public Guid NoticePriorityId { get; set; }
        public Guid NoticeStateId { get; set; }
        public Guid NoticeTypeId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid AssembleId { get; set; }
        public Guid TechnicalLocationId { get; set; }
    }
}



