using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    public class NoticeType:Entity
    {
        public string NoticeTypeCode { get; set; }
        public string NoticeTypeDescription { get; set; }
    }
}


/*
    White Card  WC,
    Red Card  RC,
    Blue Card BC,
    Yellow Card YC,
    Plant Shutdown PS,
    Fault Notice FN,
    Activity Notice AN,
    Small Stops SS,
    Other Bugs OB 
 */