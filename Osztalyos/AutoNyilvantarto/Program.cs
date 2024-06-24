namespace AutoNyilvantarto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autok a1 = new Autok("ABC-123", AutoEnum.Fiat);
            Autok a2 = new Autok("CDC-456", AutoEnum.Ford );

            a1.Megy(2.1);
            a1.Megy(2.3);

            a2.Megy(8.2);

            //Console.WriteLine(a1.AtlagFogy());
            //Console.WriteLine(a2.AtlagFogy());

            Console.WriteLine(Autok.Allomany());








        }
    }
}
