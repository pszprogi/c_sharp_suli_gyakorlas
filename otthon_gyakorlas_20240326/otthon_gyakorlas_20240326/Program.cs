using System.Drawing;

namespace otthon_gyakorlas_20240326
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //for (int i = 0; i < 128; i++)
            //{
            //    Console.WriteLine($"{i} - {(char)i}");


            //}

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.BackgroundColor = color;
                Console.ForegroundColor = 15 - color;  // 15 szín van, így az előző szín inverze lesz, mert a színek egyben számok is
                Console.WriteLine("Helló világ!");

            }

            //Console.BackgroundColor = ConsoleColor.Black;




            str





        }
    }
}
