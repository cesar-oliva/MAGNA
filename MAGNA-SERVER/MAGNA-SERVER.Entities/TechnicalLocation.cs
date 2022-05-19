using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    [Table("TechnicalLocation")]
    public class TechnicalLocation:Entity
    {
        public string TechnicalLocationCode { get; set; }
        public string TechnicalLocationDescription { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual Departament Departament { get; set; }
        public virtual Area Area { get; set; }

        [JsonIgnore]
        public virtual ICollection<Assemble> Assemble { get; set; }
    }
}
