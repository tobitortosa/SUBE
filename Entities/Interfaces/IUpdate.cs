﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    internal interface IUpdate<T>
    {
        void Update(T obj);
    }
}
