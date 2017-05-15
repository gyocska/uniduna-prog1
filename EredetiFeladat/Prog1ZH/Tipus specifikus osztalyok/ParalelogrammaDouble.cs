namespace Prog1ZH.Tipus_specifikus_osztalyok
{
    class ParalelogrammaDouble : Paralelogramma<double>
    {
        public ParalelogrammaDouble(double a, double m, string n) : base(a, m, n) { }

        public new double Terulet()
        {
            return alap * magassag;
        }
    }
}
