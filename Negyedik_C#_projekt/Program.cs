using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyedik_C__projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ora = 0;
            
            Console.Write("Kérlek add meg a pontos órát: ");
            ora = int.Parse(Console.ReadLine());


            if (ora <= 24)
            {
                if (ora >= 0 && ora <= 8)
                {
                    Console.WriteLine("Jó reggelt kívánok!");
                }
                else if (ora > 8 && ora <= 19)
                {
                    Console.WriteLine("Jó napot kívánok!");
                }
                else
                {
                    Console.WriteLine("Jó estét kívánok!");
                }
            }
            else 
            {
                Console.WriteLine("Kérlek 24-nél kisebb számot adj meg.");
            }


            Console.ReadKey();
        }
    }
}
