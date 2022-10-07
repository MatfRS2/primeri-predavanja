using System;

namespace RS2.Funkcije.ParametriOut;

class Program
{
     static void PostaviDuplirajVrednosti(out int x, out int y)
    {
        x = 5;
        y = 10;
        x += x;
        y += y;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Promenljive su deklarisane, ali nisu inicijalizovane
        int a, b;

        PostaviDuplirajVrednosti(out a, out b);
        // Prikaži početne vrednosti 
        Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(a), a);
        Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(b), b);
        Console.WriteLine();

        // Deklaracija proemnljive može da se bude u okviru argumenta poziva funkcije
        PostaviDuplirajVrednosti(out int c, out int d);
        // Prikaži vrednosti po pozivu metoda 
        Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(c), c);
        Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(d), d);
        Console.WriteLine();
    }

}

/* Izlaz dobijen prilikom izvršavanja programa:
Vrednost promenljive a je 10
Vrednost promenljive b je 20

Vrednost promenljive c je 10
Vrednost promenljive d je 20

*/