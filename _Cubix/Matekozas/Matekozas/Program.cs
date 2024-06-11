
//Random ran = new Random();
// ran.Next() //0.100 0,101

Random r = new Random();
char valasz = 'N';
Console.WriteLine("Matek gyakorló program");

Dictionary<string, int> TopLista=new Dictionary<string, int>();
do
{
    Console.WriteLine("Kérlek add meg a neved:");
    string nev = Console.ReadLine();

    if (!TopLista.ContainsKey(nev))
    {
        TopLista.Add(nev, 0);
    }

    int mit = r.Next(3);

    int x1, y1, z1;
    x1 = r.Next(1, 11);
    y1 = r.Next(1, 11);
    z1 = 0;

    switch (mit)
    {
        case 0:
            // összead
            Osszead(x1, y1, out z1);
            break;
        case 1:
            // kivonás
            Kivon(x1, y1, out z1);
            break;
        case 2:
            // szorzás
            Szoroz(x1, y1, out z1);
            break;
        default:
            break;
    }

    Console.WriteLine("Tippelj kérlek:");

    int tipp;

    while (!int.TryParse(Console.ReadLine(), out tipp))
    {
        Console.WriteLine("A tipp csak szám lehet");
    }

    if (tipp == z1)
    {
        Console.WriteLine("gratulálok, jól tippeltél!");
        TopLista[nev]++;
    }
    else
    {
        Console.WriteLine($"Sajnos nem talált, a megoldás: {z1}");
    }

    Console.WriteLine("Más is próbálkozik?");
    valasz = Console.ReadLine()[0];
} while (char.ToUpper(valasz) == 'I');

Console.WriteLine("Végeredmény:");
foreach (KeyValuePair<string, int> item in TopLista)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}


static void Osszead(int x, int y, out int z)
{
    Console.WriteLine("add össze: {0} + {1}", x, y);
    z = x + y;
}

static void Kivon(int x, int y, out int z)
{
    if (y > x)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    Console.WriteLine("vond ki: {0} - {1}", x, y);
    z = x - y;
}

static void Szoroz(int x, int y, out int z)
{
    Console.WriteLine("szorozd össze: {0} * {1}", x, y);
    z = x * y;
}