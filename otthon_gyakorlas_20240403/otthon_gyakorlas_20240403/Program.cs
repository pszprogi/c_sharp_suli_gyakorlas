using System.Linq;
using System.Numerics;

namespace otthon_gyakorlas_20240403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 számjegyek cseréje úgy, hogy az eredeti számhoz adva 9 - et kapjunk(pl. 1->8; 5->4; 0->9...) - igen

            //for (int i = 0; i < 10; i++)
            //{

            //    if (i < 9)
            //    {
            //        int a = i + (9 - i);
            //        Console.WriteLine(a);
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //string s = "Alma42Körte14";

            //foreach (var i in s)
            //{
            //    if (Char.IsDigit(i))
            //    {
            //        Console.Write(9);
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //2 ó, ió, ció, áció  - igen

            //string vakacio = "vakáció";

            //M2(vakacio);

            //static void M2(string s)
            //{
            //    for (int i = s.Length - 1; i >= 0; i--)
            //    {
            //        //Console.WriteLine(i);
            //        for (int c = i; c < s.Length; c++)
            //        {
            //            Console.Write(s[c]);
            //        }
            //        Console.WriteLine();


            //    }
            //}


            //3 minden magánhangzó megduplázása  - igen


            //string szoveg = "abcdefghija";

            //string[] maganhangzok = new string[] { "a", "e", "i" };

            //M3(szoveg, maganhangzok);

            //static void M3(string s, string[] maganhangzok)
            //{
            //    foreach (var item in maganhangzok)
            //    {
            //        if (s.Contains(item))
            //        {
            //            s = s.Replace(item, item + item);
            //        }


            //    }
            //    Console.WriteLine(s);
            //}


            //4 magánhangzók cseréje *karakterre - igen

            //string szoveg = "abcadefghijiii";

            //string[] maganhangzok = new string[] { "a", "e", "i" };

            //string uj = "";

            //M4(szoveg, maganhangzok, uj);

            //static void M4 (string s, string[] maganhangzok, string uj)
            //{

            //    foreach (var item in maganhangzok)
            //    {
            //        if (s.Contains(item))
            //        {
            //            s = s.Replace(Convert.ToChar(item), Convert.ToChar("*"));
            //        }


            //    }
            //    Console.WriteLine(s);

            //}


            //5 tetszőleges szövegrészlet kivágása(X.helytől Y hosszon) saját eljárással, hibás x és y esetén hibaüzenettel - igen

            //string szoveg = "Ez_egy_szöveg";

            //int kezdo = 1;
            //int veg = 5;

            //M5(szoveg, kezdo, veg);

            //static void M5 (string s, int k, int v)
            //{
            //    s = s.Remove(k, v);

            //    Console.WriteLine(s);
            //}


            //6 szöveg titkosítása: minden karakterhez hozzá adunk ASCII szerint X értéket(X= 1 - nél a helyett b, b helyett c stb.) - igen

            //string f6 = "TitkosABC";

            //int eltol = 3;

            //M6(f6, eltol);

            //static void M6 (string s, int eltolas) 
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        Console.Write((char)(s[i] + eltolas));  //de miért???
            //    }
            //}


            //7 minden 2.és 3.betű új szövegbe - igen

            //string szoveg = "12345678910";

            //string uj = "";
            //string regi = "";

            //M7(szoveg, uj, regi);

            //static void M7 (string s, string uj, string regi)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (i > 0 && (i + 1) % 2 == 0 || (i + 1) % 3 == 0)
            //        {
            //            uj += s[i];
            //        }
            //        else
            //        {
            //            regi += s[i];
            //        }
            //    }
            //    Console.WriteLine($"{uj} - {regi}");


            //}


            //8 szóközök kicserélés _ jelre - igen

            //string szoveg = "Ez egy nagyon hosszú szöveg.";

            //string csere = "_";

            //M8(szoveg, csere);

            //static void M8 (string s, string csere)
            //{

            //    s = s.Replace(" ", csere);

            //    Console.WriteLine(s);

            //}


            //9 minden karakter megkettőzése: abc->aabbcc - igen

            //string szoveg = "Ez egy nagyon hosszú szöveg.";


            ////string szoveg = "abc";

            //string uj = "";

            //M9(szoveg, uj);

            //static void M9(string s, string uj)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {

            //        uj += new string(s[i], 2);

            //    }
            //    Console.WriteLine(uj);
            //}


            //10 minden 3.és 5.betű cseréje * -ra - igen

            //string csere = "Szöveg cseréjét";

            //M10(csere);

            //static void M10 (string s)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if ((i+1) % 3 == 0 || (i + 1) % 5 == 0)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(s[i]);
            //        }

            //    }
            //}


            //11 kisbetűből nagybetű és nagybetűből kisbetű(pl.AbC->aBc) - igen

            //string szoveg = "AbCAbC";
            //string uj = "";


            //M11(szoveg, uj);

            //static void M11 (string s, string uj)
            //{
            //    foreach (var item in s)
            //    {
            //        //char betu = Convert.ToChar(item);
            //        if (Char.IsUpper(item))
            //        {
            //            uj += Char.ToLower(item);
            //        }
            //        else
            //        {
            //            uj += Char.ToUpper(item);
            //        }
            //    }
            //    Console.WriteLine(uj);
            //}


            //12 hullámos szöveg(pl.alma -> AlMa) - igen

            //string hullam = "ezegyhullámosszöveg";

            //M12(hullam);

            //static void M12 (string s)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(char.ToUpper(s[i]));
            //        }
            //        else
            //        {
            //            Console.Write(s[i]);
            //        }

            //    }
            //}


            //13 páros és páratlan betűk cseréje(abcd->badc) -igen

            //string szoveg = "abcd";
            //string uj = "";

            //M13(szoveg, uj);

            //static void M13 (string s, string uj)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        string betu = Convert.ToString(s[i]);
            //        if (i % 2 == 0)
            //        {
            //            uj = uj.Insert(i, betu);
            //        }
            //        else
            //        {
            //            uj = uj.Insert(i-1, betu);
            //        }

            //    }
            //    Console.WriteLine(uj);
            //}


            //14 minden számjegy megduplázása - igen

            //string szoveg = "Alma123Alma456";
            //string uj = "";

            //M14(szoveg, uj);

            //static void M14 (string s, string uj)
            //{
            //    foreach (var item in s)
            //    {
            //        if (Char.IsDigit(item))
            //        {
            //            uj += $"{item}{item}";
            //        }
            //        else
            //        {
            //            uj += item;
            //        }
            //    }
            //    Console.WriteLine(uj);
            //}


            //15 magánhangzók cseréje nagybetűsre(pl.abcde->AbcdE) - igen

            //string szoveg = "abcdefghi";
            //string[] maganhangzok = new string[] { "a", "e", "i" };

            //foreach (var item in maganhangzok)
            //{
            //    if (szoveg.Contains(item))
            //    {
            //      szoveg = szoveg.Replace(Convert.ToChar(item), Char.ToUpper(Convert.ToChar(item)));
            //    }
            //}
            //Console.WriteLine(szoveg);





            //16 Ékezettelenítő(á->a ö, ő->o)


            //17 számok cseréje betűre 1->a, 2->b stb.

            //string szoveg = "abcdef";
            //string uj = "";



            //switch (szoveg)
            //{
            //    case "a":
            //        uj += "1";
            //        break;
            //    case "b":
            //        uj += "2";
            //        break;
            //    case "c":
            //        uj += "3";
            //        break;
            //    case "d":
            //        uj += "4";
            //        break;
            //    case "e":
            //        uj += "5";
            //        break;
            //    case "f":
            //        uj += "6";
            //        break;
            //}
            //Console.WriteLine(uj);


            //18 magánhangzók megszámlálása(angol abc)


            //19 szöveg visszafelé

            //string vissza = "ez a szöveg visszafelé";

            //M19(vissza);

            //static void M19(string s)
            //{
            //    for (int i = s.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(s[i]);
            //    }
            //}


            //20 minden mássalhangzó megduplázása


            //21 számok kiválogatása szövegből(pl.a1b2c3-> 123)

            //string kivalogat = "abc123def456";

            //M21(kivalogat);

            //static void M21 (string s)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (char.IsDigit(s[i]))
            //        {

            //        }
            //        else
            //        {
            //            Console.Write(s[i]);
            //        }
            //    }



            //}





















        }
    }
}
