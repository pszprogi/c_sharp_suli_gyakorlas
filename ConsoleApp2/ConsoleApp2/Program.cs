using ConsoleApp2;

Naplo n = new Naplo();
bool kilep = false;

do
{
    Console.Clear();
    Console.WriteLine("Válasszon funkciót a kezdőbetű leütésével:");
    foreach (string nev in Enum.GetNames(typeof(Funkciok)))
    {
        Console.WriteLine(nev);
    }
    string funk = Console.ReadLine();
    char funkc = funk.Length > 0 ? char.ToUpper(funk[0]) : 'X';

    switch (funkc) //BOHFK
    {
        case 'B':
            n.Belepes();
            break;
        case 'O':
            n.Osztalyozas();
            break;
        case 'H':
            n.Hianyzas();
            break;
        case 'Z':
            n.Zaras();
            break;
        case 'J':
            n.Jegyeim();
            break;
        case 'K':
            kilep = true;
            break;
        default:
            break;
    }
} while (!kilep);