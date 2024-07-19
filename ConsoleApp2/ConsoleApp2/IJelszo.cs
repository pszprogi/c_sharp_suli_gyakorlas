namespace ConsoleApp2
{
    interface IJelszo
    {
        public string Jelszo { get; set; }

        public bool Belepett { get; set; }

        public void Belepes(string tipp);
    }
}
