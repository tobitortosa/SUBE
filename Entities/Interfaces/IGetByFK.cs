using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    internal interface IGetByFK<T>
    {
        List<T> GetByFK(string pk);
    }
}
