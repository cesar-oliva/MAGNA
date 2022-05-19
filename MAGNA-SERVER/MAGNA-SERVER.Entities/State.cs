using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    [Table("State")]
    public class State : Entity
    { 
        public string StateDescription { get; set; }
    }
}
