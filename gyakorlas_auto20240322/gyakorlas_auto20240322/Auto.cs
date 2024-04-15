using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas_auto20240322
{
    internal class Auto
    {
            public string Marka { get; set; }
            public string Tipus { get; set; }
            public string Szin { get; set; }
            public int Evjarat { get; set; }

            public Auto() { }

            public Auto(string marka, string tipus, string szin, int evjart)
            {
                Marka = marka;
                Tipus = tipus;
                Szin = szin;
                Evjarat = evjart;
            }

            public override string ToString()
            {
                return $"{Marka}, {Tipus}, {Szin}, {Evjarat}";
            }

        
    }
}
