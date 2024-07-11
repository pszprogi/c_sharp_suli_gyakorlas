
using Leszarmazas;



Ember ujember = new Ember();
Console.WriteLine(ujember);
ujember.Eletkor = 11;
ujember.Olvas();
ujember.Mozog(12);

string s = ujember.ToString();
Console.WriteLine(s);


Diak d1 = new Diak();
Console.WriteLine(d1);
d1.Eletkor = 11;
d1.Olvas();
d1.Mozog(20);
d1.Mozog(50);


Tanar t1 = new Tanar();
Console.WriteLine(t1);
t1.Eletkor = 33;
t1.Olvas();
t1.Mozog(30);


Auto a = new Auto();
Console.WriteLine(a);
a.Halad(11);
a.Haladas(20);
a.Haladas(50);
















