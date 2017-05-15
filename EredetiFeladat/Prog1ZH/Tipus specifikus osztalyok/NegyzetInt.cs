using System;

namespace Prog1ZH.Tipus_specifikus_osztalyok
{
    class NegyzetInt : Negyzet<int>
    {
        public NegyzetInt(int oldal, string n) : base(oldal, oldal, n) { }

        public override int Atlo()
        {
            return Convert.ToInt32(Math.Sqrt(alap * alap + magassag * magassag));
        }

        public override int Kerulet()
        {
            return (alap + magassag) * 2;
        }

        public override int Terulet()
        {
            return alap * magassag;
        }
    }
}
