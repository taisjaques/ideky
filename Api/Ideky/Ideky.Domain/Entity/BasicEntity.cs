﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideky.Domain.Entity
{
    interface BasicEntity
    {
        List<string> Messages { get; }

        bool Validate();
    }
}
