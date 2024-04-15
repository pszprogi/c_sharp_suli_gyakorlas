namespace c_8_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "9Alma42Körte14";

            foreach (var i in s)
            {
                bool eredmeny = int.TryParse(s, out _);
                if (eredmeny)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }



        }
    }
}
