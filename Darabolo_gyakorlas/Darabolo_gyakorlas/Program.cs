namespace Darabolo_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek adj meg egy szöveget.");
            string szoveg = Console.ReadLine();

            Console.WriteLine("Mekkora darabokra vágjam?");
            int meret;
            while (!int.TryParse(Console.ReadLine(), out meret))
            {
                Console.WriteLine("Nem jó a méret");

            }

            string[] eredmeny;

            if (szoveg.Length % meret == 0)
            {
                eredmeny = new string[szoveg.Length / meret];
            }
            else
            {
                eredmeny = new string[szoveg.Length / meret + 1];
            }

            int counter = 0;

            while (szoveg.Length > 0)
            {
                if (szoveg.Length <= meret)
                {
                    eredmeny[counter] = szoveg;
                    szoveg = string.Empty;
                }
                else
                {
                    eredmeny[counter] = szoveg.Substring(0, meret);
                    szoveg = szoveg.Substring(meret);
                }
                counter++;
            }






        }
    }
}
