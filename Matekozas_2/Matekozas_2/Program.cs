namespace Matekozas_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //rnd.Next();

            char valasz = 'N';

            Dictionary<string, int> Toplista = new Dictionary<string, int>();        

            Console.WriteLine("Matek gyakorló.");


            do
            {

                Console.WriteLine("Kérlek add meg a neved.");

                string nev = Console.ReadLine();

                if (!Toplista.ContainsKey(nev))
                {
                    Toplista.Add(nev, 0);

                }

                int mit = rnd.Next(0, 3);

                int x1, y1, z1;
                x1 = rnd.Next(1, 11);
                y1 = rnd.Next(1, 11);
                z1 = 0;



                switch (mit)
                {
                    case 0:
                        // összead
                        Osszeadas(x1, y1, out z1);
                        break;

                    case 1:
                        // kivonás
                        Kivonas(x1, y1, out z1);
                        break;

                    case 2:
                        // szorzás
                        Szoroz(x1, y1, out z1);
                        break;

                    default:
                        break;
                }


                Console.WriteLine("Tippelj kérlek:");

                int tipp;

                while (!int.TryParse(Console.ReadLine(), out tipp))
                {
                    Console.WriteLine("A tipp csak szám lehet.");


                }

                if (tipp == z1)
                {
                    Console.WriteLine("Gratulálok, jól tippeltél.");
                    Toplista[nev]++;

                }
                else
                {
                    Console.WriteLine($"Nem talált, a helyes megoldás: {z1}");
                }



                static void Osszeadas(int x, int y, out int z)
                {
                    int a = 100;
                    Console.WriteLine("Add össze a következő számokat {0} + {1}",x, y);
                    z = x + y;
                }


                Console.WriteLine("Más is próbálkozik?");
                valasz = Console.ReadLine()[0];

            } while (char.ToUpper(valasz) == 'I');


            Console.WriteLine("Végeredmény:");
            foreach (KeyValuePair<string, int> item in Toplista)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }


   

static void Kivonas(int x, int y, out int z)
            {
                if (y > x)
                {
                    int temp = x;
                    x = y;
                    y = temp;
                }

                Console.WriteLine("Vond ki egymásból a két számot {0} - {1}", x, y);
                z = x - y;

            }

            static void Szoroz(int x, int y, out int z)
            {
                Console.WriteLine("Szorozd össze a következő számokat {0} * {1}", x, y);
                z = x * y;
            }




        }
    }
}