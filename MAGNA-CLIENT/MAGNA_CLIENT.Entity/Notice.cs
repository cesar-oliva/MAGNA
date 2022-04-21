using MAGNA_CLIENT.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Entities
{
    public class Notice:Entity
    {
        public string NoticeCode { get; set; }
        public string NoticeDescription { get; set; }
        public virtual NoticeType NoticeType { get; set; }
        public DateTime NoticeDate { get; set; }
        public virtual NoticePriority NoticePriority { get; set; }
        public string FaultType { get; set; }
        public string TechnicalLocation { get; set; }
        public string AffectedPart { get; set; }
        public string FaultDescription { get; set; }
        public virtual NoticeCategory NoticeCategory { get; set; }
        public virtual NoticeState NoticeState { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Assemble Assemble { get; set; }
    }
}
