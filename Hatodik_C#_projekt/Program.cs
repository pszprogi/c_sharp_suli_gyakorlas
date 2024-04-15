using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatodik_C__projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] string_tomb = new string[10];
            //bool[] bool_tom = new bool[10];

            //int[] tomb = new int[10];
            //int szam = tomb[0];

            //for (int i = 0; i < 10; i++)
            //{
            //    tomb[i] = i;
            //}

            //for (int i = 0; i < tomb.Length; i++ )
            //{
            //    Console.WriteLine(tomb[i]);
            //}


            List<int> adatok = new List<int>();

            for(int i = 0; i < 20; i++ )
            {
                adatok.Add(i);
            }

            for (int i = 0; i < adatok.Count(); i++)
            {
                Console.WriteLine(adatok[i]);
            }












            Console.ReadKey();
        }
    }
}
