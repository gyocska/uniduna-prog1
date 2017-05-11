using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH.Tipus_specifikus_osztalyok
{
    class TrapezDouble : Trapez<double>
    {
        public TrapezDouble(double a, double m) : base(a, m) { }

        public double Kerulet(double felsoHossz, double szarHossz)
        {
            return alap + felsoHossz + szarHossz * 2;
        }

        public double Terulet(double felsoHossz)
        {
            return ((alap + felsoHossz) * magassag) / 2;
        }
    }
}
