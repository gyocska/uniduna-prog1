using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH
{
    class Paralelogramma<T> : Negyszog<T>, IParalelogramma<T>
    {
        public Paralelogramma(T a, T m) : base(a, m) { }

        public T Kerulet()
        {
            throw new NotImplementedException();
        }

        public override void Kiir()
        {
            throw new NotImplementedException();
        }
    }
}
