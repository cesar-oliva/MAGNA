using MAGNA_CLIENT.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Entities
{
    public class Assemble:Entity
    {
        public Guid Id { get; set; }
        public string AssembleCode { get; set; }
        public string AssembleDescription { get; set; }
        public AssembleType AssembleType { get; set; }
        
    }
}
