using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLib
{
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }
}
