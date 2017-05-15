using Prog1ZH2.Generikus_absztrakt_osztalyok;
using System;

namespace Prog1ZH2.Tipus_specifikus_osztalyok
{
    class ParalelogrammaDouble : Paralelogramma<double>
    {
        public ParalelogrammaDouble(double alap, double magassag) : base(alap, magassag)
        {
        }

        public override double Kerulet()
        {
            throw new NotImplementedException();
        }

        public override double Terulet()
        {
            return alap * magassag;
        }
    }
}
