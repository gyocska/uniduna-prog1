using System;

namespace Prog1ZH
{
    class Paralelogramma<T> : Negyszog<T>, IParalelogramma<T>
    {
        private readonly string name;

        public Paralelogramma(T a, T m, string n) : base(a, m) {
            this.name = n;
        }

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
