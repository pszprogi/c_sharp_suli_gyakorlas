using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otodik_C__projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.Write("kérek egy számot: ");
            //    int szam = int.Parse(Console.ReadLine());
            //}
            //catch
            //{
            //Console.WriteLine("Há hülye vagy, ez nem szám!");
            //}

            Console.Write("Jegyed: ");
            int jegy = int.Parse(Console.ReadLine());

            switch(jegy)
            {
                case 5:
                    {
                        Console.WriteLine("Jeles");
                        break;                       
                    }
                case 4:
                    {
                        Console.WriteLine("Jó");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Közepes");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Elégséges");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Elégtelen");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nincs ilyen osztályzat.");
                        break;                                                          
                    }


            }



            Console.ReadKey();
        }
    }
}
