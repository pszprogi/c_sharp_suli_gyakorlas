using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas20240308
{
    public class Car
    {
        public string colour;
        public string type;
        public string brand;
        public int ccm;

        public Car() { } //alapból csak ez az üres konstruktor van, ami nem is látszik. Ha a következő módon felhasználjuk, akkor kell kiírni.

        public Car(string colour, string type, string brand, int ccm)
        {
            this.colour = colour;
            this.type = type;
            this.brand = brand;
            this.ccm = ccm;
        
        
        
        }

        public void Sound()
        {
            Console.WriteLine("Wrooom wrooom!");

        }
    }
}
