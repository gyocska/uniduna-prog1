using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH
{
    interface ITrapez<T>
    {
        T Kerulet(T felsoHossz, T szarHossz);

        T Terulet(T felsoHossz);

        void Kiir();
    }
}
