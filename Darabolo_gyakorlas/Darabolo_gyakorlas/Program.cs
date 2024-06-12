namespace Darabolo_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg;
            int meret;
            string[] eredmeny;


            Bekeres(out szoveg, out meret);

            eredmeny = Meretezes(szoveg, meret);
    
            Darabolas(szoveg, meret, eredmeny);

            Kiiras(eredmeny);





            static void Kiiras(string[] eredmeny_belso_kiiras)
            {
                foreach (string darab in eredmeny_belso_kiiras)
                {
                    Console.Write($"{darab}-");
                }
            }
                   
            static void Bekeres(out string szoveg_ki, out int meret_ki)
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

            static string[] Meretezes(string szoveg, int meret) //hány darab lesz, ez adja meg, hogy mekkora legyen a tömb
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

            static void Darabolas(string szoveg, int meret, string[] eredmeny_belso)
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
}
