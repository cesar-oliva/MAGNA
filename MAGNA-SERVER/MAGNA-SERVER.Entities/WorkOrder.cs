using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    public class WorkOrder : Entity
    {
        public string WorkOrderCode { get; set; }
        public string WorkOrderDescription { get; set; }
        public DateTime WorkOrderStartingDate { get; set; }
        public DateTime WorkOrderEndingDate { get; set; }


        //llave foranea
        public int EmployeeId { get; set; }
        public int NoticeId { get; set; }
        public int WorkOrderStateId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Notice Notice { get; set; }
        public virtual WorkOrderState WorkOrderState { get; set; }

    }
}
