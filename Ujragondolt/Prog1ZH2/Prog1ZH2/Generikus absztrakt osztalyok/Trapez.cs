namespace Prog1ZH2.Generikus_absztrakt_osztalyok
{
    abstract class Trapez<T> : Negyszog<T>
    {
        protected T felsoHossz;
        protected T szarHossz;

        public Trapez(T alap, T magassag, T felsoHossz, T szarHossz) : base(alap, magassag)
        {
            this.felsoHossz = felsoHossz;
            this.szarHossz = szarHossz;
        }

        public override string Nev
        {
            get
            {
                return "trapéz";
            }
        }
    }
}
