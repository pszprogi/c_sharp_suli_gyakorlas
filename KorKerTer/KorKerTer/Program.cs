namespace KorKerTer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem egy kör sugarát: ");
            int sugar = 0;

            //if (int.TryParse(Console.ReadLine(), out sugar))
            //{
            //    Console.WriteLine("Számolok.");
            //}
            //else 
            //{
            //    Console.WriteLine("kérlek számot adj meg.");
            //};


            while (!int.TryParse(Console.ReadLine(), out sugar))
            {
                Console.WriteLine("Kérlek, számot adj meg!");
            }


            double ker = 2 * sugar * Math.PI;
            double ter = Math.Pow(sugar, 2) * Math.PI;

            Console.WriteLine(ter);
            Console.WriteLine(ker);

            

        }
    }
}
