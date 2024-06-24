using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNyilvantarto
{
    public class Autok
    {
        static int osszAllomany;

        public string Rendszam { get; } //így csal érhető lesz

        public AutoEnum Tipus { get; }

        List<double> Fogyasztas;

        double amortizacio = 100;

        static Autok()
        {
            osszAllomany = 1;
        
        
        }

        public Autok(string rsz, AutoEnum tip)
        {
            Rendszam = rsz;
            Tipus = tip;
            Fogyasztas = new List<double>();
            osszAllomany++;
        }

        public static int Allomany()
        {
            return osszAllomany;  
        }

        public void Megy(double atlagFogyasztas)
        {
            Fogyasztas.Add(atlagFogyasztas);
        }

        public double AtlagFogy()
        {
            double osszesFogyasztas = 0;

            foreach (double egyfogy  in Fogyasztas)
            {
                osszesFogyasztas += egyfogy;
            }

            return osszesFogyasztas / Fogyasztas.Count;
        }

        private void Amortizalodik()
        {
            amortizacio *= 0.001;
        
        
        
        
        }







    }
}
