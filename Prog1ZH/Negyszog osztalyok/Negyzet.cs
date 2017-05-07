using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH
{
    class Negyzet<T> : Negyszog<T>, INegyzet<T>
    {
        public Negyzet(T a, T m) : base(a, m) { }

        public T Atlo()
        {
            throw new NotImplementedException();
        }

        public T Kerulet()
        {
            throw new NotImplementedException();
        }

        public T Terulet()
        {
            throw new NotImplementedException();
        }

        public override void Kiir()
        {
            throw new NotImplementedException();
        }
    }
}
