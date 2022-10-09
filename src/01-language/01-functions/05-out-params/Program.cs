/*

Parametar out

The out keyword causes arguments to be passed by reference. 
It makes the formal parameter an alias for the argument, which must be a 
variable. 
In other words, any operation on the parameter is made on the argument. 
It is like the ref keyword, except that ref requires that the variable be 
initialized before it is passed. 
It is also like the in keyword, except that in does not allow the called method 
to modify the argument value. 
To use an out parameter, both the method definition and the calling method 
must explicitly use the out keyword.

*/

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