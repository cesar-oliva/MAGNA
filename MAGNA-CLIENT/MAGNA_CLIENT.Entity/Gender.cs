using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Entities
{
    public  class Gender:Entity
    {
        public Guid Id { get; set; }
        public string GenderDescription { get; set; }
        public bool GenderState { get; set; }
    }
}
