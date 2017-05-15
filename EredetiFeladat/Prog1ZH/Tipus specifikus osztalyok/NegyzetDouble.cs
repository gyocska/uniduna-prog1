using System;

namespace Prog1ZH.Tipus_specifikus_osztalyok
{
    class NegyzetDouble : Negyzet<double>
    {
        public NegyzetDouble(double oldal, string n) : base(oldal, oldal, n) { }

        public override double Atlo()
        {
            return Math.Sqrt(alap * alap + magassag * magassag);
        }

        public override double Kerulet()
        {
            return (alap + magassag) * 2;
        }

        public override double Terulet()
        {
            return alap * magassag;
        }
    }
}
