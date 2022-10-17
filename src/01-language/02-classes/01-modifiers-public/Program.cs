
using System;

/*
 
Sklopovi

Nivo pristupa public 

Pristup javnom elementu je dopušten iz svakog dela programa. 
To znači da ma koji drugi metod ili mamkoji srugi sklop koji sadrži referencu na klasu
može pristupiti elemtnu označenom sa public. 
Ovaj modifikator pristupa daje najšire dopuštenje u poređenju sa ostalim novpima pristupa.

 */
using RS2.Klase.ElementiPublic;

namespace RS2.Klase.KoriscenjeElementiPublic;

class Program
{

    // Main Method 
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Student stud = new Student(1, "Митар Митровић");

        Console.WriteLine("Ознака:        {0}", stud.getBrojIndeksa());
        Console.WriteLine("Име и презиме: {0}", stud.getImePrezime());
        Console.WriteLine();

        //Console.WriteLine("Ознака:        {0}", stud.brojIndeksa);
        //Console.WriteLine("Име и презиме: {0}", stud.imePrezime);
    }
}

/* Izlaz dobijen prilikom izvršavanja programa:
 
Ознака:        1
Име и презиме: Митар Митровић

*/

