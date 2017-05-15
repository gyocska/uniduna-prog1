using Prog1ZH.Tipus_specifikus_osztalyok;

namespace Prog1ZH
{
    class Program
    {
        static void Main(string[] args)
        {
            new Negyszog<int>(12, 12).Kiir();
            NegyzetInt negyzet1 = new NegyzetInt(12, "négyzet");
            negyzet1 = null; // nem szüntettük meg, csak a rá mutató referenciát GC.Collect(); ?
            NegyzetDouble negyzet2 = new NegyzetDouble(12, "négyzet");
            negyzet2.Kiir();
            new TrapezDouble(12, 12, "trapéz");
            new ParalelogrammaDouble(12, 12, "paralelogramma");
        }
    }
}
