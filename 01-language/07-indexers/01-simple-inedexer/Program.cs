
using System;


namespace RS2.SimpleIndexer
{
    class Program
    {
        static void Main()
        {
            Niske elementi = new Niske();

            elementi[0] = "Jedan";
            elementi[1] = "Dva";
            elementi[2] = "Tri";
            elementi[7] = "Cetiri";
            elementi.Prikazi();

            elementi.Dimenzija = 15;
            elementi[-17] = "Osam";
            elementi.Prikazi();
        }

    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Jedan
Dva
Tri
Cetiri






---
Jedan
Dva
Tri
Cetiri



Osam




 */

