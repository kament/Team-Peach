﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public interface IHerbivorous
    {
        List<Plant> Food { get; }
    }
}
