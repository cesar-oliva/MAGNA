using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.Abstractions
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
