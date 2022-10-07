

using System;

namespace RS2.Klase.NasledjivanjeKonstruktor;

class Program
{

    static void Main(string[] args)
    {
        Student stud = new Student(1, "Astrid");

        Console.WriteLine("Roll number: {0}", stud.getBrojIndeksa());
        Console.WriteLine("Name: {0}", stud.getImePrezime());
        Console.WriteLine();

        //Console.WriteLine("Roll number: {0}", stud.brojIndeksa);
        //Console.WriteLine("Name: {0}", stud.imePrezime);
        //Console.WriteLine();

    }
}

