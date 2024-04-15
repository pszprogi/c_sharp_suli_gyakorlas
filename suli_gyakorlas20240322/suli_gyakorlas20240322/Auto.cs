using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suli_gyakorlas20240322
{
    internal class Auto
    {
        public string Marka { get; set };
        public string Tipus { get; set };
        public string Szin { get; set };
        public int Evjarat { get; set };

        public Auto() { }

        public Auto(string marka, string tipus, string szin, int evjarat) 
        {
            Marka = marka;
            Tipus = tipus;
            Szin = szin;
            Evjarat = evjarat;
        }

        public override string ToString()
        {
            return $"Márka: {Marka}, tipusa: {Tipus}, színe: {Szin}, évjárata: {Evjarat}";
        }






    }
}
