namespace suli_gyakorlas20240322_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ingatlan> ingatlanok = new List<Ingatlan>() {
               new Ingatlan("Klárafalva", "ház", 60, 10.5),
               new Ingatlan("Szeged", "lakás", 48, 27.3),
               new Ingatlan("Hódmezővásárhely", "garázs", 10, 27.3),
               new Ingatlan("Budapest", "iroda", 25, 33.3)
            };

            foreach (var ingatlan in ingatlanok)
            {
                Console.WriteLine(ingatlan);
                //Console.WriteLine(ingatlan.);
            }


        }
    }
}
