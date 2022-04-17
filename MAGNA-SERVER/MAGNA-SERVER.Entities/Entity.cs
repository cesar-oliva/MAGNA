using MAGNA_SERVER.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Entities
{
    public abstract class Entity : IEntity
    {
        [Key]
        public Guid Id { get ; set; }
    }
}
