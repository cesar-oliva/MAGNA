﻿using MAGNA_CLIENT.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Entities
{
    public class Entity: IEntity
    {
        public Guid Id { get; set; }
    }
}
