using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Entities
{
    public class AssembleVersion
    {
        public string AssembleLocation { get; set; }
        public string AssembleMaker { get; set; }
        public string AssemblePurchaseDate { get; set; }
        public string AssembleSerialNumber { get; set; }
        public int AssembleDayGuarantee { get; set; }
        public ICollection<Assemble> SubAssemble { get; set; }
    }
}
