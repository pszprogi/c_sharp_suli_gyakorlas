using DaraboloOsztalyLib;

namespace Darabolo_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //using DaraboloOsztalyLib;
            
            Szodarabolo sd1 = new Szodarabolo();
            Szodarabolo sd2 = new Szodarabolo();


            if (sd1.AdatBekeres())
            {
                sd1.Kiiras();
            }




            if (sd2.AdatBekeres())
            {
                sd2.Kiiras();
            }
            


        }
    }
}

