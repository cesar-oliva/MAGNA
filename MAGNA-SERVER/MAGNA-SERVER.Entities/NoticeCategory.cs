using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    [Table("Noticecategory")]
    public class NoticeCategory : Entity
    {
        public string NoticeCategoryDescription { get; set; }
        public bool NoticeCategoryState { get; set; }

        [JsonIgnore]
        public virtual ICollection<Notice> Notice { get; set; }
    }
}
