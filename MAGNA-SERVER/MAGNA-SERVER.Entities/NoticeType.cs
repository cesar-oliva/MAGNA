using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{ 
    [Table("NoticeType")]
    public class NoticeType:Entity
    {
        public string NoticeTypeCode { get; set; }
        public string NoticeTypeDescription { get; set; }

        [JsonIgnore]
        public virtual ICollection<Notice> Notice { get; set; }
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