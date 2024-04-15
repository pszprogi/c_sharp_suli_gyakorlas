namespace gyakorlas_auto20240322
{
    internal class Program
    {
        static List<Auto> autok = new List<Auto>();
        static void autoHozzaAd()
        {
            Console.Clear();
            Console.Write("Márka: ");
            string marka = Console.ReadLine();
            Console.Write("Típus: ");
            string tipus = Console.ReadLine();
            Console.Write("Szín: ");
            string szin = Console.ReadLine();
            Console.Write("Évjárat: ");
            int evjarat = Convert.ToInt32(Console.ReadLine());
            autok.Add(new Auto(marka, tipus, szin, evjarat));

            Console.WriteLine("Az adat sikeresen felvéve!");
            Thread.Sleep(1000);
            Console.Clear();
        }

        static void autokKiir()
        {
            Console.Clear();
            foreach (var auto in autok)
            {
                Console.WriteLine("\t-" + auto);
            }
            Console.WriteLine();
        }

        static void autoModosit()
        {
            Console.WriteLine("Melyik autót szeretnéd módosítani: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Márka: ");
            string marka = Console.ReadLine();
            Console.Write("Típus: ");
            string tipus = Console.ReadLine();
            Console.Write("Szín: ");
            string szin = Console.ReadLine();
            Console.Write("Évjárat: ");
            int evjarat = Convert.ToInt32(Console.ReadLine());

            autok[index] = new Auto(marka, tipus, szin, evjarat);
            Console.WriteLine("Autó sikeresen módosítva!");
        }

        static void autoTorles()
        {
            Console.WriteLine("Melyik autót szeretnéd törölni: ");
            int index = Convert.ToInt32(Console.ReadLine());
            autok.RemoveAt(index);
            Console.WriteLine("Autó sikeresen törölve!");
        }

        static void fajlbairas()
        {
            List<string> data = new List<string>();

            foreach (var auto in autok)
            {
                data.Add($"{auto.Marka},{auto.Tipus},{auto.Szin},{auto.Evjarat}");
            }

            File.WriteAllLines("autok.csv",data);
        }

        static List<Auto>fajlbolOlvas() 
        {
            List<Auto> temp = new List<Auto>();
            string[] file = File.ReadAllLines("autok.csv");

            foreach (var sor in file) 
            {
                string[] tokens = sor.Split(new char[] { ',' });
                temp.Add(new Auto(tokens[0], tokens[1], tokens[2], Convert.ToInt32(tokens[3])));
            }

            return temp;
        }


        static void Main(string[] args)
        {

            bool fut = true;
            while (fut)
            {

                Console.WriteLine("1. Autó hozzáadása");
                Console.WriteLine("2. Autók listázása");
                Console.WriteLine("3. Autó módosítása");
                Console.WriteLine("4. Autó törlése");
                Console.WriteLine("5. Autó fajlbairása");
                Console.WriteLine("6. Autó beolvasása");
                Console.WriteLine("7. Kilépés");

                Console.Write("Kérlek válassz az alábi menüpontokból: ");
                int valasztas = Convert.ToInt32(Console.ReadLine());

                switch (valasztas)
                {
                    case 1:
                        autoHozzaAd();
                        break;
                    case 2:
                        autokKiir();
                        break;
                    case 3:
                        autoModosit();
                        break;
                    case 4:
                        autoTorles();
                        break;
                    case 5:
                        fajlbairas();
                        break;
                    case 6:
                        fajlbolOlvas();
                        break;
                    case 7:
                        fut = false;
                        break;
                    default:
                        Console.WriteLine("Nincs ilyen opció!");
                        break;
                }
            }

        }
    }
}
