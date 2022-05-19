using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    public class AssembleSubAssemble:Entity
    {
        public Guid AssembleId { get; set; }
        public Guid AssembleVersionId { get; set; }
        public Assemble Assemble { get; set; }
        public SubAssemble AssembleVersion { get; set; }
    }
}
