using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1ZH
{
    abstract class Negyszog<T>
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
            Console.WriteLine("A NÉGYSZÖGEK ADATAI");
            Console.WriteLine("===================");
        }
    }
}
