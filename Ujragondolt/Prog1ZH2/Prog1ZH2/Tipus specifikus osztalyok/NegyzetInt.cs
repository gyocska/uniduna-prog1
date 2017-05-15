using Prog1ZH2.Generikus_absztrakt_osztalyok;
using System;

namespace Prog1ZH2.Tipus_specifikus_osztalyok
{
    class NegyzetInt : Negyzet<int>
    {
        public NegyzetInt(int oldal) : base(oldal)
        {
        }

        public override int Atlo()
        {
            return Convert.ToInt32(Math.Sqrt(2 * Math.Pow(alap, 2)));
        }

        public override int Kerulet()
        {
            return 4 * alap;
        }

        public override int Terulet()
        {
            return alap * alap;
        }
    }
}
