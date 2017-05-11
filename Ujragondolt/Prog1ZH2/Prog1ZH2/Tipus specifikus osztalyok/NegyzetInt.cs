using System;

namespace Prog1ZH2
{
    class NegyzetInt : Negyzet<int>
    {
        public NegyzetInt(int oldal) : base(oldal)
        {
            if (alap != magassag)
            {
                throw new Exception("Valamit elcsesztem, negyzet eseten az alap es a magassag egyenlo kellene hogy legyen.");
            }
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
