using System;

namespace RS2.Funkcije.ParametriOut;

class Program
{
    static int SaberiDupliraneVrednosti(in int x, in int y)
    {
        // x += y;
        // return 2 * x;
        return 2 * (x + y);
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int a = 7, b = 9;

        int c = SaberiDupliraneVrednosti(in a, in b);
        // Prikaži vrednost koju vraće metod 
        Console.WriteLine("Vrednost dupliranog zbira je {0}", c);
    }

}

/* Izlaz dobijen prilikom izvršavanja programa:
 
Vrednost dupliranog zbira je 32

*/