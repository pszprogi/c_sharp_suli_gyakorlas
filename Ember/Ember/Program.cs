namespace Ember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Jozsi = new Person("Józsi", 40);
            Person Pista = new Person("Pista", 35);

            Jozsi.WriteInformation();
            Pista.WriteInformation();



        }
    }
}
