using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nyolcadik_C__projekt
{
    internal class Program
    {
        public struct ember 
        {
            public string vezeteknev;
            public string keresztnev;
            public int eletkor;      
        }

        public static List<ember> Adatok = new List<ember>();

        static void Main(string[] args)
        {
            //Beolvasás

            FileStream f = new FileStream("adatok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f, Encoding.UTF8);

            ember aktualis = new ember();

            while(!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(' ');
                aktualis.vezeteknev = sor[0];
                aktualis.keresztnev = sor[1];
                aktualis.eletkor = Convert.ToInt32(sor[2]);

                Adatok.Add(aktualis);
            }
            sr.Close();
            f.Close();

            Console.WriteLine("Az adatok beolvasása megtörtént.");
            Console.WriteLine("A fájlban lévő adatok: ");

            for (int i = 0; i < Adatok.Count; i++)
            {
                Console.WriteLine($"{Adatok[i].vezeteknev} {Adatok[i].keresztnev} {Adatok[i].eletkor}.");

            }

            //Kiírás

            Console.Write("Kérek egy vezetéknevet:");
            string vezeteknev = Console.ReadLine();
            Console.Write("Kérek egy keresztnevet: ");
            string keresztnev = Console.ReadLine();
            Console.Write("Kérek egy kort: ");
            int kor = Convert.ToInt32(Console.ReadLine());

            FileStream iras = new FileStream("adatok_2.txt", FileMode.Create);
            StreamWriter stiras = new StreamWriter(iras);

            for (int i = 0; i < Adatok.Count; i++)
            {
                stiras.WriteLine($"{Adatok[i].vezeteknev} {Adatok[i].keresztnev} {Adatok[i].eletkor}");
            }
            stiras.WriteLine($"{vezeteknev} {keresztnev} {kor}");

            stiras.Close();
            iras.Close();

            Console.ReadKey();
        }
    }
}
