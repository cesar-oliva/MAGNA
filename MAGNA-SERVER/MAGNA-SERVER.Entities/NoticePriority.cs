using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    [Table("NoticePriority")]
    public class NoticePriority : Entity 
    {
        public string NoticePriorityDescription { get; set; }
        public bool NoticePriorityState { get; set; }

        [JsonIgnore]
        public virtual ICollection<Notice> Notice { get; set; }
    }
}

   