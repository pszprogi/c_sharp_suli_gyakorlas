namespace ConsoleApp2
{
    internal class Diak : Dolgozo
    {
        public List<int> Osztalyzatok { get; }

        public Diak()
        {
            Osztalyzatok = new List<int>();
        }

        public void UjJegy(int jegy)
        {
            Osztalyzatok.Add(jegy);
        }

        public override void Eredmeny()
        {
            Console.WriteLine("{0} elért átlaga: {1}", Nev, Segito.Atlag(Osztalyzatok));
        }

        public void JegyListazas()
        {
            foreach (int jegy in Osztalyzatok)
            {
                Console.WriteLine(jegy);
            }
        }

    }
}
