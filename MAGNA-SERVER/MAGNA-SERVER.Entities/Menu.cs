using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{   
    public class Menu : Entity
    {
        public string MenuDescription { get; set; }
        public int MenuIdFhater { get; set; }
        public string MenuUrl { get; set; }
        public int MenuStatus { get; set; }
    }
}
