using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLib
{
    interface Iterator
    {
        bool HasNext();
        object Next();
    }
}
