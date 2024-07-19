namespace ConsoleApp2
{
    public abstract class Dolgozo : IJelszo
    {
        public int Hianyzas { get; set; }
        public string Nev { get; set; }
        public string Jelszo { get; set; }
        public bool Belepett { get; set; }

        public void Belepes(string tipp)
        {
            if (tipp == Jelszo)
            {
                Belepett = true;
            }
        }

        public virtual void Eredmeny() { }

        public override string ToString()
        {
            return Nev;
        }
    }
}
