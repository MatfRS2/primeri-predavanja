/*
 

Nivo pristupa protected 

Pristup zaštićenom elementu je ograničen na klasu koja sadrži taj elemenat i na klase koje
nju nasleđuju. 
To znači da se u svakoj od klasa koja nasleđuje datu klasu može pristupiti zaštićenim 
elementima date klase. 

 */
using System;

namespace RS2.ModifiersProtected;
class X
{
    // Elemenat x je deklarisan kao protected 
    protected int x;

    public X()
    {
        x = 10;
    }
}

class Y : X
{

    // Iz metoda u klasi Y se može pristupiti elementu 'x' 
    public int GetX()
    {
        return x;
    }
}

class Program
{

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Prikaz vrednosti za x je uspešan, jer se korsti metod iz Y
        Y obj1 = new Y();
        Console.WriteLine("Вредност за x: {0}", obj1.GetX());

        // Prikaz vrednosti za x nije moguć
        // X obj2 = new X(); 
        // Console.WriteLine("Вредност за x: {0}", obj2.x);
    }
}

/* Izlaz dobijen prilikom izvršavanja programa:
 
Вредност за x: 10

*/
