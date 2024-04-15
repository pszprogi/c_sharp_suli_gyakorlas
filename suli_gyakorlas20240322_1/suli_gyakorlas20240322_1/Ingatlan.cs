using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suli_gyakorlas20240322_1
{
    internal class Ingatlan
    {

        public string location;
        private string type;
        private int area;
        private double price;

        public Ingatlan() { }

        public Ingatlan(string location, string type, int area, double price)
        {
            this.location = location;
            this.type = type;
            this.area = area;
            this.price = price;
        }

        //public string Location { get; set};



        public override string ToString()
        {
            return location + " " + type + " " + area + " " + price;
        }
    }
}
}
