
using System;

/*
 
Sklopovi

Sklop (eng. assembly) je osnovna jedinica za isporuku, kontrolu verzije, ponovnu iskoristivost, 
opsege aktivacije i postavljanje sigurnosnih prava kod .NET aplikacija. 
To je skup tipova i resursa koji su prevedeni i izgrađeni da rade zajedno i da oforme logičku 
jedinicu funkcionalnosti 
Sklopovi imaju obik izvršne datoteke (.exe) ili biblioteke za dinamičko vezivanje (.dll). 
Ukratko, sklopvi su gradivni blokaovi za .NET aplikacije. 

Prostori imena

Prostori imena služe za organizovanje klasa.
To je imenovna grupa klasa koje iamju zajedničke karakteristike.
Oni pomažu u kontroli opsega za metode i klase kod većih .NET programskih projekata. 
Može se reći da oni obezbeđuju da jedan skup imena (npr. imena klasa) ne bude u koliziji sa 
drugim skupom imena. 
Prostori imena mohu sadržavati klase, prostore imena, interfejse, strukture i delegate.
  

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

