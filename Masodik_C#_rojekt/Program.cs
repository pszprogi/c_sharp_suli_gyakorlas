using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodik_C__rojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double atlag = 0.00;
            double szorzata = 1;

            for (int i = 0; i < 11; i++)
            {
                sum += i;
            }
            int j = 1;
            while(j < 11)
            {
                szorzata *= j;
                j++;

            }
            atlag = sum / 10;
            Console.WriteLine($"A számok összege: {sum}.");
            Console.WriteLine($"A számok átlaga: {atlag}.");
            Console.WriteLine($"A számok szorzata: {szorzata}.");

            Console.ReadKey();
        }
    }
}
