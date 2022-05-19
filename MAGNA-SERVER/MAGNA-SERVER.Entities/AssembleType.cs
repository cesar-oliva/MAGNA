using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    [Table("AssembleType")]
    public class AssembleType : Entity
    {
        public string AssembleTypeCode { get; set; }
        public string AssembleTypeDescription { get; set; }

        [JsonIgnore]
        public virtual ICollection<Assemble> Assemble { get; set; }
    }
}
