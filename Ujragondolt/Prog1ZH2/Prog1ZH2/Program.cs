using System;

namespace Prog1ZH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A NÉGYSZÖGEK ADATAI");
            Console.WriteLine("===================");

            NegyzetInt negyzet = new NegyzetInt(12);
            negyzet.Kiir();
        }
    }
}
