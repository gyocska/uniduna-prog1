using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH
{
    class Negyzet<T> : Negyszog<T>, INegyzet<T>
    {
        private readonly string name = "négyzet";

        public Negyzet(T a, T m) : base(a, m) { }

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
