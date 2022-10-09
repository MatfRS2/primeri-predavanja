/*

Parametar in

The in keyword causes arguments to be passed by reference but ensures the argument is not modified. 
It makes the formal parameter an alias for the argument, which must be a variable. 
In other words, any operation on the parameter is made on the argument. 
It is like the ref or out keywords, except that in arguments cannot be modified by the called method. 
Whereas ref arguments may be modified, out arguments must be modified by the called method, and those 
modifications are observable in the calling context.
Variables passed as in arguments must be initialized before being passed in a method call. 
However, the called method may not assign a value or modify the argument.
Although in, out, and ref parameter modifiers are considered part of a signature, members declared in a single 
type cannot differ in signature solely by in, ref and out. 
Therefore, methods cannot be overloaded if the only difference is that one method takes a ref or out argument 
and the other takes an in argument.

*/

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