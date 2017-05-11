using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH.Tipus_specifikus_osztalyok
{
    class ParalelogrammaDouble : Paralelogramma<double>
    {
        public ParalelogrammaDouble(double a, double m) : base(a, m) { }

        public new double Terulet()
        {
            return alap * magassag;
        }
    }
}
