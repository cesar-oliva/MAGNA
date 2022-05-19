using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    [Table("NoticeState")]
    public class NoticeState:Entity 
    {
        public string NoticeStateCode{ get; set; }
        public string NoticeStateDescription { get; set; }

        [JsonIgnore]
        public virtual ICollection<Notice> Notice { get; set; }
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