using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    [Table("SubAssemble")]
    public class SubAssemble:Assemble
    {
        [Required]
        public int AssembleVersionNumber { get; set; }

        [JsonIgnore]
        public List<AssembleSubAssemble> AssembleSubAssemblies { get; set; }
    }
}
