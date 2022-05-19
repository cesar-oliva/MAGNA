using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Entities
{
    public class AssembleProperty:Entity
    {
        [Required]
        public string AssembleMaker { get; set; }
        [Required]
        public string AssembleSerialNumber { get; set; }
        [Required]
        public string AssemblePurchaseDate { get; set; }
        [Required]
        public string AssembleDayGuarantee { get; set; }
    }
}
