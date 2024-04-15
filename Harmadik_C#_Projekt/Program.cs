using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmadik_C__Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vezeteknev = "";
            string keresztnev = "";
            string monogram = "";

            Console.Write("Kérem a vezeteknevét: ");
            vezeteknev = Console.ReadLine();
            Console.Write("Kérem a keresztnevét: ");
            keresztnev = Console.ReadLine();

            monogram = vezeteknev[0].ToString() + keresztnev[0].ToString() + keresztnev[1].ToString();

            Console.WriteLine($"A mongramm: {monogram}.");




            Console.ReadKey();
        }
    }
}
