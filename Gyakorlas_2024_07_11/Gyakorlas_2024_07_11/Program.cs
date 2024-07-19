using System.Security.Cryptography.X509Certificates;

namespace Gyakorlas_2024_07_11
{
    internal class Program
    {
 

        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy szöveget, ami szám.");
            //string szam_ami_szoveg = Console.ReadLine();

            int eredmeny;
                
              

        while (!int.TryParse(Console.ReadLine(), out eredmeny))
            {
                Console.WriteLine("Adj meg egy szöveget, ami szám.");
                Console.WriteLine("Nem szám.");


            }

            Console.WriteLine(eredmeny);










            }
    }
}
