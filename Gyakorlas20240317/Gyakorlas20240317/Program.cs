namespace Gyakorlas20240317
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Szia, hogy hívnak? : ");
            string name;
            name = Console.ReadLine();
            if (name == "Szabolcs") 
            {
                Console.WriteLine("Szia Szabolcs!");         
            } else 
            {
                Console.WriteLine("Nem ismerlek.");
            }

            Console.ReadKey();
        }
    }
}
