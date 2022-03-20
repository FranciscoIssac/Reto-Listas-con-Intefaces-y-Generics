using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Listas_con_Interfaces_y_Generics
{
    internal interface Iterator<T>
    {
        Boolean hasNext();
        T next();
    }
}
