using System;

namespace RS2.Funkcije.MetodiProsirenja;

class Program
{
    static void StampajViseLinija(int z)
    {
        for (int i = 0; i < z; i++)
            Console.WriteLine("-- " + i + " --");
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int z = 2;
        StampajViseLinija(z);
        Console.WriteLine("Здраво свете!");
        StampajViseLinija(z);

        z = Prosirenje.BrojSlova("123 Мики Маус 123");
        Console.WriteLine(z);
        Console.WriteLine(Prosirenje.Nalepi("Паја Патак ", 2));
        Console.WriteLine(Prosirenje.Nalepi("Шиља ", 4));

        z = "123 Мики Маус 123".BrojSlova();
        Console.WriteLine(z);
        Console.WriteLine("Паја Патак ...".Nalepi(2));
        Console.WriteLine("Шиља - ".Nalepi(4));
    }

}

/* Izlaz dobijen prilikom izvršavanja programa:
 
-- 0 --
-- 1 --
Здраво свете!
-- 0 --
-- 1 --
0
Паја Патак Паја Патак Паја Патак
Шиља Шиља Шиља Шиља Шиља
0
Паја Патак ...Паја Патак ...Паја Патак ...
Шиља - Шиља - Шиља - Шиља - Шиља -

*/
