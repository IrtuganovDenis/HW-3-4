using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    interface IProvider<T>
    {
        T Rand();
        T ByUser();
    }
}
