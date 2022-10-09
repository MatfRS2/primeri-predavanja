/*

Parametar ref 

When used in a method's parameter list, the ref keyword indicates that an argument is passed by 
reference, not by value. 
The ref keyword makes the formal parameter an alias for the argument, which must be a variable. 
In other words, any operation on the parameter is made on the argument.
To use a ref parameter, both the method definition and the calling method must explicitly use 
the ref keyword.
An argument that is passed to a ref or in parameter must be initialized before it's passed. 
Members of a class can't have signatures that differ only by ref, in, or out. 
A compiler error occurs if the only difference between two members of a type is that one of them 
has a ref parameter and the other has an out, or in parameter.

*/

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
        int a = 10, b = 12;

        // Prikaži inicijlne vrednosti
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
Vrednost promenljive b je 20

Vrednost promenljive c je 10
Vrednost promenljive d je 20

*/