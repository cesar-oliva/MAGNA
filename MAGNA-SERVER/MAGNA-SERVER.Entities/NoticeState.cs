using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    public class NoticeState:Entity 
    {
        public string NoticeStateCode{ get; set; }
        public string NoticeStateDescription { get; set; }
    }
}

/* 
OPNO: Open Notice
PMNO: There are pending measures in notices
MANO: All measurements made
CLNO: Notice closed
TRNO: Notice in Treatment
DENO: Delete Request
ASOR: Assigned Order
 */