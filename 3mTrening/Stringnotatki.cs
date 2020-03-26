using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3mTrening
{
    class Stringnotatki

    {
        public Stringnotatki()
        {
            string ala = "ala";
            ala = ala + "ma";
            ala = ala + "kota";
            StringBuilder teskstringbuildera = new StringBuilder();
            teskstringbuildera.Append("ala");
            teskstringbuildera.Append("ma");
            teskstringbuildera.Append("kota");
            Console.WriteLine(ala);
            Console.WriteLine(teskstringbuildera);
        }
    }
}
