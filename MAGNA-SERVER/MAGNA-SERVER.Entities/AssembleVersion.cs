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
    public class AssembleVersion : Entity
    {
        [Required]
        public string AssembleVersionCode { get; set; }
        [Required]
        public string AssembleVersionDescription { get; set; }
        [Required]
        public int AssembleVersionNumber { get; set; }
        [Required]
        public virtual Location Location { get; set; }
        [Required]
        public string AssembleMaker { get; set; }
        [Required]
        public string AssembleSerialNumber { get; set; }
        [Required]
        public string AssemblePurchaseDate { get; set; }
        [Required]
        public string AssembleDayGuarantee { get; set; }

        public virtual ICollection<AssembleProperty> Properties { get; set; }

        [JsonIgnore]
        public virtual ICollection<Assemble> Assemblies { get; set; }
    }
}
