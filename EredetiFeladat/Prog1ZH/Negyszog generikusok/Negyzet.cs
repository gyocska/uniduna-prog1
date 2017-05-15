using System;

namespace Prog1ZH
{
    class Negyzet<T> : Negyszog<T>, INegyzet<T>
    {
        private readonly string name;

        public Negyzet(T a, T m, string n) : base(a, m) {
            this.name = n;
        }

        public virtual T Atlo()
        {
            throw new NotImplementedException();
        }

        public virtual T Kerulet()
        {
            throw new NotImplementedException();
        }

        public virtual T Terulet()
        {
            throw new NotImplementedException();
        }

        public override void Kiir()
        {
            Console.WriteLine("A " + name + " kerülete: " + Kerulet());
            Console.WriteLine("A " + name + " területe: " + Terulet());
            Console.WriteLine("A " + name + " átlója: " + Atlo());
        }
    }
}
