using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leszarmazas
{

    interface IHaladas
    {
        public int Y { get; set; }

        public void Haladas(int tav);
    }



    public abstract class Eloleny //az abstract miatt nem lehet példányosítani
    {
        public int X { get; set; }
        public abstract void Mozog(int x);
    }

    public class Ember : Eloleny, IHaladas
    {
        public int Eletkor { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return "Ez egy ember.";
        }

        public virtual void Olvas()
        {
            Console.WriteLine("Én még nem tudok olvasni.");
        }

        public override void Mozog(int x)
        {
            X += x;
            Console.WriteLine($"Odébbmentem {x} méterrel. Hol járok: {X}");
        }

        public void Haladas(int tav)
        {
            Y += tav;
            Console.WriteLine($"Hol járok? {Y}");
        }
    }

    public class Diak : Ember
    {
        public override string ToString()
        {
            return "Én diák vagyok.";
        }

        public override void Olvas()
        {
            Console.WriteLine("Olvasgatok.");
        }
    }

    public class Tanar : Ember
    {
        public override void Olvas()
        {
            Console.WriteLine("Sokat olvasok.");
        }

    }

    public class Auto : IHaladas
    {
        public int Y { get; set; }

        public void Halad(int x)
        {
            Console.WriteLine($"Hol járok? {x}");

        }

        public void Haladas(int tav)
        {
            Y += tav;
            Console.WriteLine($"Hol járok? {Y}");
        }
    }

}
