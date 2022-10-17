/*

Parametar ref 

Кључна реч ref у листи параметара метода указује да се приликом позива врши супституција по референци, а не по вредности. 

Ова кључна реч чини да (формални) параметар буде само друго име за променљиву која је аргумент у позиву функције. 

Овде ма која операција над параметром у ствари рализује над аргументом (аргумент мора бити променљива).

Када се користи ref параметар, тада и параметар у декларацији метода и аргумент у позиву метода морају бити експлицитно значени са ref.

Аргумент у позиву маркиран са  ref мора бити иницијализован пре позива. 
 
Members of a class can't have signatures that differ only by ref, in, or out. 

A compiler erда се ror occurs if the only difference between two members of a type is that one of them 
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