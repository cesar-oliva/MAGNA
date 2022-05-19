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
    [Table("Assemble")]
    public class Assemble : Entity
    {
        [Required]
        public string AssembleCode { get; set; }
        [Required]
        [StringLength(100)]
        public string AssembleDescription { get; set; }
        [Required]
        public Guid AssembleTypeId { get; set; }
        [Required]
        public Guid TechnicalLocationId { get; set; }
        [Required]
        public string AssembleMaker { get; set; }
        [Required]
        public string AssembleSerialNumber { get; set; }
        [Required]
        public string AssemblePurchaseDate { get; set; }
        [Required]
        public string AssembleMonthsGuarantee { get; set; }

        [JsonIgnore]
        public virtual ICollection<Notice> Notice { get; set; }
        [JsonIgnore]
        public List<AssembleSubAssemble> AssembleSubAssemblies { get; set; }


    }
}
