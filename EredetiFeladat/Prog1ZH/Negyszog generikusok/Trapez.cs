using System;

namespace Prog1ZH
{
    class Trapez<T> : Negyszog<T>, ITrapez<T>
    {
        private readonly string name;

        public Trapez(T a, T m, string n) : base(a, m) {
            this.name = n;
        }

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
