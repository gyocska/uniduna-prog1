using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH
{
    interface INegyzet<T>
    {
        T Kerulet();

        T Terulet();

        T Atlo();

        void Kiir();
    }
}
