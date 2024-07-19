namespace ConsoleApp2
{
    internal class Tanar : Dolgozo
    {
        public int Fizetes { get; set; }

        public Tanar(int fiz)
        {
            Fizetes = fiz;
        }

        public override void Eredmeny()
        {
            Console.WriteLine("{0} havi fizetése: {1} HUF", Nev, Fizetes / 30 * (30 - Hianyzas));
        }
    }
}
