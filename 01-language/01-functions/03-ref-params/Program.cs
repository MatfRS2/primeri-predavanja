

using System;

namespace RS2.Funkcije.ParametriRef;

class Program
{

    // Vrši se supstitucija po vrednosti
    static void DodajVrednost(int x)
    {
        x += 10;
    }

    // Vrši se supstitucija po referenci
    static void OduzmiVrednost(ref int y)
    {
        y -= 5;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Inicijalizuj vrednosti za a, b 
        int a = 10, b = 10;

        // Prikaži inicijalne vrednosti
        Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(a), a);
        Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(b), b);
        Console.WriteLine();

        DodajVrednost(a);
        Console.WriteLine("Vrednost promenljive {0} " +
            "nakon izvršenog dodavanja je {1}", nameof(a), a);
        Console.WriteLine();

        OduzmiVrednost(ref b);
        Console.WriteLine("Vrednost promenljive {0} " +
            "nakon izvršenog oduzimanja je {1}", nameof(b), b);
        Console.WriteLine();

    }

}

/* Izlaz dobijen prilikom izvršavanja programa:
Vrednost promenljive a je 10
Vrednost promenljive b je 12

Vrednost promenljive a nakon izvršenog dodavanja je 10

Vrednost promenljive b nakon izvršenog oduzimanja je 7

*/