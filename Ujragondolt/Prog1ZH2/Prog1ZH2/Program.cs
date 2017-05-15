using System;
using Prog1ZH2.Tipus_specifikus_osztalyok;

namespace Prog1ZH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A NÉGYSZÖGEK ADATAI");
            Console.WriteLine("===================");

            NegyzetInt negyzet1 = new NegyzetInt(12);
            negyzet1 = null; // nem szüntettük meg, csak a rá mutató referenciát GC.Collect(); ?

            NegyzetDouble negyzet2 = new NegyzetDouble(12);
            negyzet2.Kiir();

            new TrapezDouble(12, 12, 6, 4);
            new ParalelogrammaDouble(12, 12);
        }
    }
}
