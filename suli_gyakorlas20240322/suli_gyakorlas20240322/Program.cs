namespace suli_gyakorlas20240322
{
    internal class Program
    {
        static List<Auto> autok = new List<Auto>();
        static void autoHozzaAd()
        {
            Console.Write("Márka:");
            string marka = Console.ReadLine();
            Console.Write("Tipus:");
            string tipus = Console.ReadLine();
            Console.Write("Szín:");
            string szin = Console.ReadLine();
            Console.Write("Évjárat:");
            int evjarat = Convert.ToInt32(Console.ReadLine());

            autok.Add(new Auto(marka, tipus, szin, evjarat));



            Console.WriteLine("Az adat felvitele sikeresen megtörtént");
        }

        static void autoKiir()
        { 
            foreach (var auto in autok)
            {
                Console.WriteLine(auto);

            }
        
        }

        static void autoModosito()
        {
            Console.WriteLine("Melyiket szeretnéd módosítani");
            int index = Convert.ToInt32(Console.ReadLine());
            Auto atmeneti = autok[index];

            Console.Write("Márka:");
            string marka = Console.ReadLine();
            Console.Write("Tipus:");
            string tipus = Console.ReadLine();
            Console.Write("Szín:");
            string szin = Console.ReadLine();
            Console.Write("Évjárat:");
            int evjarat = Convert.ToInt32(Console.ReadLine());

            autok[index] = new Auto(marka,tipus,szin,evjarat);


        }
        static void autoTorles()
        {
            Console.WriteLine("Melyiket szeretnéd módosítani");
            int index = Convert.ToInt32(Console.ReadLine());

            autok.Remove(index);

            Console.WriteLine("Autók sikeresen módosítva.");



        }




        static void Main(string[] args)
        {

            
                List<Auto> autok = new List<Auto>()
                {
  

                };


            while (true)
            {
                Console.WriteLine("1, Autó hozzáadása");
                Console.WriteLine("2, Autók listázása");
                Console.WriteLine("3, Autó modosítása");
                Console.WriteLine("4, Autó törlése");
                Console.WriteLine("5, Kilépés");

                Console.WriteLine("Válasszon egy opciót.");
                int valasztas = Convert.ToInt32(Console.ReadLine());





                switch (valasztas)
                {
                    case 1:
                        autoHozzaAd();
                        break;
                    case 2:
                        autoKiir();
                        break;
                    case 3:
                        autoTorles();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;



                }

            }




         

        




        }
    }
}
