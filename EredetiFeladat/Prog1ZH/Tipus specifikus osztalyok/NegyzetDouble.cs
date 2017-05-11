using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH.Tipus_specifikus_osztalyok
{
    class NegyzetDouble : Negyzet<double>
    {
        public NegyzetDouble(double a, double m) : base(a, m) { }

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
