using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hetedik_c__projekt
{
    internal class Program
    {
        public struct ember
        {
            public string keresztnev;
            public int eletkor;

        }

        static void Main(string[] args)
        {
            ember dolgozo = new ember();

            dolgozo.eletkor = 19;
            dolgozo.keresztnev = "Szabolcs";

            Console.WriteLine($"{dolgozo.keresztnev} életkora: {dolgozo.eletkor}.");



            ember[] dolgozok = new ember[5];
            dolgozok[0].eletkor = 19;
            dolgozok[0].keresztnev = "Lajos";
            dolgozok[1].eletkor = 20;
            dolgozok[1].keresztnev = "Béla";
            dolgozok[2].eletkor = 55;
            dolgozok[2].keresztnev = "Áron";
            dolgozok[3].eletkor = 67;
            dolgozok[3].keresztnev = "Géza";
            dolgozok[4].eletkor = 10;
            dolgozok[4].keresztnev = "Pistike";

            for (int i = 0; i < dolgozok.Length; i++)
            {
                Console.WriteLine($"{dolgozok[i].keresztnev} életkora: {dolgozok[i].eletkor}.");



            }




            Console.ReadKey();
        }
    }
}
