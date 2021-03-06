using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    public class Gender : Entity
    {
        public string GenderDescription { get; set; }
        public bool GenderState { get; set; }

        [JsonIgnore]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
