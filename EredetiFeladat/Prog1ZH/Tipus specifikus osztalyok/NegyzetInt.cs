using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH.Tipus_specifikus_osztalyok
{
    class NegyzetInt : Negyzet<int>
    {
        public NegyzetInt(int oldal) : base(oldal, oldal) { }

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
