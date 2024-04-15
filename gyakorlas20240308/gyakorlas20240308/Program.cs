namespace gyakorlas20240308
{
    //osztály
    //minden elé kell a public, különben privát lesz

    //public class Score
    //{
    //    public string name;
    //    public int points;
    //    public int level;

    //    public bool EarnedStar()
    //    {
    //        return (points / level) > 1000;
    //    }
    //}

    //public class Person
    //{
    //    public string name;
    //    public int age;
    //    public double height;

    //    public void Drink()
    //    {
    //        Console.WriteLine("Éppen iszok");
    //    }

    //    public void Drink(string drink) //ha kap paramétert, akkor ezt írja ki, ha nem, akkor az előzőt
    //    {
    //        Console.WriteLine("Éppen " + drink + " iszok");
    //    }



    //}




    internal class Program
    {
        static void Main(string[] args)
        {
            //Score score = new Score();
            //score.name = "John";
            //score.level = 1;
            //score.points = 1001;

            //Console.WriteLine(score.EarnedStar());


            //Person csaba = new Person();
            //csaba.name = "Nagy Csaba";
            //csaba.age = 100;
            //csaba.height = 1.83;

            //Console.WriteLine($"Név: {csaba.name}, Kor: {csaba.age}, Magassága: {csaba.height}.");

            //csaba.Drink("kólát");


            Car car = new Car();

            car.brand = "Mitsubishi";
            car.colour = "kék";
            car.ccm = 3000;
            car.type = "Evo";

            Console.WriteLine($"Márka: {car.brand}, Típus: {car.type},Szín: {car.colour}.");

            car.Sound();



            Car car2 = new Car();

            car2.brand = "Mitsubishi";
            car2.colour = "kék";
            car2.ccm = 3000;
            car2.type = "Evo";

            Console.WriteLine($"Márka: {car2.brand}, Típus: {car2.type},Szín: {car2.colour}.");


            Car car3 = new Car("kék", "Evo", "Mitsubishi", 3000);

            Console.WriteLine($"Márka: {car3.brand}, Típus: {car3.type},Szín: {car3.colour}.");




        }
    }
}
