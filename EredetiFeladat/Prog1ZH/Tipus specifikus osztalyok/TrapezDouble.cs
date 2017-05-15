namespace Prog1ZH.Tipus_specifikus_osztalyok
{
    class TrapezDouble : Trapez<double>
    {
        public TrapezDouble(double a, double m, string n) : base(a, m, n) { }

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
