namespace ConsoleApp2
{
    internal class Naplo : IJelszo
    {
        public string Jelszo { get; set; }
        public bool Belepett { get; set; }

        List<Tanar> TanarList;
        List<Diak> DiakList;
        List<Dolgozo> Mindenki;

        public Naplo()
        {
            TanarList = new List<Tanar>();
            DiakList = new List<Diak>();
            Mindenki = new List<Dolgozo>();

            Tanar t1 = new Tanar(123456);
            t1.Nev = "t-Peti";
            TanarList.Add(t1);

            Tanar t2 = new Tanar(654321);
            t2.Nev = "t-Kati";
            TanarList.Add(t2);

            Diak d1 = new Diak();
            d1.Nev = "d-Laci";
            DiakList.Add(d1);

            Diak d2 = new Diak();
            d2.Nev = "d-Anna";
            DiakList.Add(d2);

            Diak d3 = new Diak();
            d3.Nev = "d-Sanyi";
            DiakList.Add(d3);

            Diak d4 = new Diak();
            d4.Nev = "d-Misi";
            DiakList.Add(d4);

            Mindenki.AddRange(DiakList);
            Mindenki.AddRange(TanarList);

            foreach (Dolgozo dolgozo in Mindenki)
            {
                ((IJelszo)dolgozo).Jelszo = "ures";
            }
            Jelszo = "admin";
        }

        public void Jegyeim()
        {
            Diak diak = (Diak)Kivalasztas(false, true);
            if (diak.Belepett)
            {
                diak.JegyListazas();
            }
            else
            {
                Console.WriteLine("csak a saját jegyeidet tudod lekérdezni!");
            }
            Console.ReadLine();
        }

        public void Belepes()
        {
            if (Belepett)
            {
                Console.WriteLine("Kit szeretnél beléptetni?");
                Dolgozo kit = Kivalasztas(true, true);
                Console.WriteLine("Kérem a jelszót!");
                ((IJelszo)kit).Belepes(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Kérem a napló jelszót!");
                Belepes(Console.ReadLine());
            }
        }

        public void Osztalyozas()
        {
            Console.WriteLine("Ki osztályoz?");
            if (!Kivalasztas(true, false).Belepett)
            {
                Console.WriteLine("Osztályzáshoz lépjen be!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Kit osztályoz?");
            Diak kit = (Diak)Kivalasztas(false, true);
            Console.WriteLine("Kérem az osztályzatot!");
            int jegy = Segito.Szambekero(5);
            kit.UjJegy(jegy);
        }

        public void Hianyzas()
        {
            Console.WriteLine("Ki hiányzik?");
            Kivalasztas(true, true).Hianyzas++;
        }

        public void Zaras()
        {
            if (Belepett)
            {
                foreach (Dolgozo dolgozo in Mindenki)
                {
                    dolgozo.Eredmeny();
                }
            }
            else
            {
                Console.WriteLine("A zárás funkcióhoz napló belépés szükséges.");
            }
            Console.ReadLine();
        }

        public void Belepes(string tipp)
        {
            if (tipp == Jelszo)
            {
                Belepett = true;
            }
        }

        private Dolgozo Kivalasztas(bool tanar, bool diak)
        {
            if (tanar && diak)
            {
                for (int i = 0; i < Mindenki.Count; i++)
                {
                    Console.WriteLine($"{i} - {Mindenki[i]}");
                }
                int kit = Segito.Szambekero(Mindenki.Count);
                return Mindenki[kit];
            }

            if (tanar)
            {
                for (int i = 0; i < TanarList.Count; i++)
                {
                    Console.WriteLine($"{i} - {TanarList[i]}");
                }
                int kit = Segito.Szambekero(TanarList.Count);
                return TanarList[kit];
            }

            if (diak)
            {
                for (int i = 0; i < DiakList.Count; i++)
                {
                    Console.WriteLine($"{i} - {DiakList[i]}");
                }
                int kit = Segito.Szambekero(DiakList.Count);
                return DiakList[kit];
            }

            return null;
        }
    }
}
