using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    public class Location : Entity
    {
        public string LocationCode { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual Departament Departament { get; set; }
        public virtual Area Area {get; set; }
    }
}

