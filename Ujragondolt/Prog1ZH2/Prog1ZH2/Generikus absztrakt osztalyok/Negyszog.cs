using Prog1ZH2.Interfeszek;
using System;

namespace Prog1ZH2.Generikus_absztrakt_osztalyok
{
    abstract class Negyszog<T> : ISikidom<T>, IKiirathato
    {
        protected T alap;
        protected T magassag;

        public abstract string Nev { get; }

        public Negyszog(T alap, T magassag)
        {
            this.alap = alap;
            this.magassag = magassag;
        }

        public abstract T Kerulet();

        public abstract T Terulet();

        public virtual void Kiir()
        {
            Console.WriteLine("A {0} területe: {1}", Nev, Terulet());
            Console.WriteLine("A {0} kerülete: {1}", Nev, Kerulet());
        }
    }
}
