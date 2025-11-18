

using System;

namespace RS2.Klase.NasledjivanjeKonstruktor;

/*
 
U ovom primeru je klasa Student izvedena iz klase Covek.
Svaka od klasa je definisana u posebnoj datoteci. 
Konstruktor klase Student poziva konstruktor klase Covek.  

*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Student stud = new Student(1, "Митар Митровић");

        Console.WriteLine("Ознака:        {0}", stud.GetBrojIndeksa());
        Console.WriteLine("Име и презиме: {0}", stud.GetImePrezime());
        Console.WriteLine("---");

        stud = new Student(2);
        Console.WriteLine("Ознака:        {0}", stud.GetBrojIndeksa());
        Console.WriteLine("Име и презиме: {0}", stud.GetImePrezime());
    }
}

/* Izlaz dobijen prilikom izvršavanja programa:
 
Ознака:        1
Име и презиме: Митар Митровић
---
Ознака:        2
Име и презиме: Непознат студент


*/


