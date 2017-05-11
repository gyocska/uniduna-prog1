using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH
{
    class Trapez<T> : Negyszog<T>, ITrapez<T>
    {
        private readonly string name = "trapéz";

        public Trapez(T a, T m) : base(a, m) { }

        public T Kerulet(T felsoHossz, T szarHossz)
        {
            throw new NotImplementedException();
        }

        public T Terulet(T felsoHossz)
        {
            throw new NotImplementedException();
        }

        public override void Kiir()
        {
            throw new NotImplementedException();
        }
    }
}
