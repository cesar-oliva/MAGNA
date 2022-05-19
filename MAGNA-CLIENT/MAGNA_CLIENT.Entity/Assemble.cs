using MAGNA_CLIENT.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Entities
{
    public class Assemble:Entity
    {
        [Required]
        public string AssembleCode { get; set; }
        [Required]
        [StringLength(100)]
        public string AssembleDescription { get; set; }
        [Required]
        public virtual AssembleType AssembleType { get; set; }
        [Required]
        public virtual TechnicalLocation TechnicalLocation { get; set; }
        [Required]
        public virtual AssembleProperty AssembleProperty { get; set; }

    }
}

