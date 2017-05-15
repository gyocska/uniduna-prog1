using Prog1ZH2.Generikus_absztrakt_osztalyok;

namespace Prog1ZH2.Tipus_specifikus_osztalyok
{
    class TrapezDouble : Trapez<double>
    {
        public TrapezDouble(double alap, double magassag, double felsoHossz, double szarHossz)
            : base(alap, magassag, felsoHossz, szarHossz)
        {
        }

        public override double Kerulet()
        {
            return alap + felsoHossz + szarHossz * 2;
        }

        public override double Terulet()
        {
            return ((alap + felsoHossz) * magassag) / 2;
        }
    }
}

