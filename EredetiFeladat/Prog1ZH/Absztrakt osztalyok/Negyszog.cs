using System;

namespace Prog1ZH
{
    class Negyszog<T>
    {
        protected T alap;
        protected T magassag;

        public Negyszog(T a, T m)
        {
            alap = a;
            magassag = m;
        }

        public virtual void Kiir()
        {
            Console.WriteLine("A NÉGYSZÖGEK ADATAI:");
            Console.WriteLine("====================");
        }
    }
}
