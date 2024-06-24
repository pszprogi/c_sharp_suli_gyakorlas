using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaraboloOsztalyLib
{
    public class Szodarabolo
    {

        //field, 
        string szoveg;
        int meret;
        string[] eredmeny;

        //property - getter-setterrel adjuk meg
        public bool Sikeres { get; set; }



        public void Kiiras()
        {
            if (Sikeres)
            {
                foreach (string darab in eredmeny)
                {
                    Console.Write($"{darab}-");
                }
                Console.WriteLine();
            }
        }


        public bool AdatBekeres()
        {
            Bekeres(out szoveg, out meret); //Ennek kell legelöl lennie, mert ebből jön meg a szöveg, ezért van az out

            eredmeny = Meretezes(szoveg, meret);

            Darabolas(szoveg, meret, eredmeny);

            Sikeres = true;

            return true;                        
        }


        private void Bekeres(out string szoveg_ki, out int meret_ki)
        {
            Console.WriteLine("Kérlek adj meg egy szöveget.");
            //string szoveg_belso = Console.ReadLine();
            szoveg_ki = Console.ReadLine();

            Console.WriteLine("Mekkora darabokra vágjam?");

            //int meret_belso;


            while (!int.TryParse(Console.ReadLine(), out meret_ki)) //meret_belso
            {
                Console.WriteLine("Nem jó a méret");

            }

            //szoveg_ki = szoveg_belso;
            //meret_belso = meret_ki;
        }

        private string[] Meretezes(string szoveg, int meret) //hány darab lesz, ez adja meg, hogy mekkora legyen a tömb
        {
            string[] eredmeny_belso;

            if (szoveg.Length % meret == 0)
            {
                eredmeny_belso = new string[szoveg.Length / meret];
            }
            else
            {
                eredmeny_belso = new string[szoveg.Length / meret + 1];
            }

            return eredmeny_belso;
        }

        private void Darabolas(string szoveg, int meret, string[] eredmeny_belso)
        {
            int counter = 0;

            while (szoveg.Length > 0)
            {
                if (szoveg.Length <= meret)
                {
                    eredmeny_belso[counter] = szoveg;
                    szoveg = string.Empty;
                }
                else
                {
                    eredmeny_belso[counter] = szoveg.Substring(0, meret);
                    szoveg = szoveg.Substring(meret);
                }
                counter++;
            }
        }
    }
}
