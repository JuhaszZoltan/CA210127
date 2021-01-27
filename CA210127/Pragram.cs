using CA210127;
using System;

Random rnd = new Random();
var s = "Hello World!";

for (int i = 0; i < 10; i++)
{
    Console.ForegroundColor = (ConsoleColor)rnd.Next(16);
    Console.WriteLine(s);

    Osszead(rnd.Next(10), rnd.Next(20));
}

static int Osszead(int x, int y) => x + y;

Tanulo t1 = new()
{ 
    Nev = "Zolika",
    Id = 1,
    Szul = new(1990, 07, 11),
};


Tanulo t2 = null;

if(t2 is not null)
{
    //valami
}
else if(t2 is null)
{

}

//összehasonlító / logika switch exp.

MasikFajtaTanulo t8 = new("béla", 11);

int jegy = rnd.Next(1, 6);

var ertekeles = jegy switch
{
    < 1 or > 5 => "hiba",
    1 => "elégtelen",
    2 => "elégséges",
    _ => "egyéb",
};

record MasikFajtaTanulo(string Nev, int Kor);