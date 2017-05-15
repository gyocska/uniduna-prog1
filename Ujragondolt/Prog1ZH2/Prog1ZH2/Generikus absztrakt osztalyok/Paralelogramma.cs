namespace Prog1ZH2.Generikus_absztrakt_osztalyok
{
    abstract class Paralelogramma<T> : Negyszog<T>
    {
        public Paralelogramma(T alap, T magassag) : base(alap, magassag)
        {
        }

        public override string Nev
        {
            get
            {
                return "paralelogramma";
            }
        }
    }
}
