using System;

namespace Prog1ZH2.Generikus_absztrakt_osztalyok
{
    abstract class Negyzet<T> : Negyszog<T>
    {
        public Negyzet(T oldal) : base(oldal, oldal)
        {
        }

        public override string Nev
        {
            get
            {
                return "négyzet";
            }
        }

        public abstract T Atlo();

        public override void Kiir()
        {
            base.Kiir();
            Console.WriteLine("A {0} átlója: {1}", Nev, Atlo());
        }
    }
}
