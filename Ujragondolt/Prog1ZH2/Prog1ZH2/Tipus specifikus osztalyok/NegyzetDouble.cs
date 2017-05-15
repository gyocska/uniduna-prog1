using Prog1ZH2.Generikus_absztrakt_osztalyok;
using System;

namespace Prog1ZH2.Tipus_specifikus_osztalyok
{
    class NegyzetDouble : Negyzet<double>
    {
        public NegyzetDouble(double oldal) : base(oldal)
        {
        }

        public override double Atlo()
        {
            return Math.Sqrt(2 * Math.Pow(alap, 2));
        }

        public override double Kerulet()
        {
            return 4 * alap;
        }

        public override double Terulet()
        {
            return alap * alap;
        }
    }
}
