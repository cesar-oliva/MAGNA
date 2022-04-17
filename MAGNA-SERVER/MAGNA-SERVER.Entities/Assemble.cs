using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    [Table("Assemble")]
    public class Assemble : Entity
    {
        [Required]
        public string AssembleCode { get; set; }
        [Required]
        public string AssembleDescription { get; set; }
        [Required]//llave foranea
        public Guid AssembleTypeId { get; set; }
       
    }
}
