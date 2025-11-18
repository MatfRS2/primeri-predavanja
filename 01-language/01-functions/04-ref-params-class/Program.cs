using System;

namespace RS2.Funkcije.ParametriRefUMetodu;

class AlgebarskiKompleksni
{

    private int realniDeo, imaginarniDeo;

    public AlgebarskiKompleksni(int r, int i)
    {
        realniDeo = r;
        imaginarniDeo = i;
    }

    public int GetRe()
    {
        return realniDeo;
    }

    public int GetIm()
    {
        return imaginarniDeo;
    }

    public static void Azuriraj1(AlgebarskiKompleksni obj)
    {
        obj.realniDeo += 5;
        obj.imaginarniDeo += 5;
    }

    public static void Azuriraj2(ref AlgebarskiKompleksni obj)
    {
        obj.realniDeo += 5;
        obj.imaginarniDeo += 5;
    }

    public static void Azuriraj3(AlgebarskiKompleksni obj)
    {
        obj = new AlgebarskiKompleksni(1, 2);
    }

    public static void Azuriraj4(ref AlgebarskiKompleksni obj)
    {
        obj = new AlgebarskiKompleksni(1, 2);
    }

}

class Program
{

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        AlgebarskiKompleksni kompl = new AlgebarskiKompleksni(2, 4);
        Console.WriteLine("Kompleksni broj {0} =  {1} + i {2}", nameof(kompl),
            kompl.GetRe(), kompl.GetIm());

        AlgebarskiKompleksni.Azuriraj1(kompl);
        Console.WriteLine("Posle \"normalnog\" ažuriranja gde se modifikuju polja {0}", nameof(kompl));
        Console.WriteLine("Kompleksni broj {0} =  {1} + i {2}", nameof(kompl),
            kompl.GetRe(), kompl.GetIm());

        AlgebarskiKompleksni.Azuriraj2(ref kompl);
        Console.WriteLine("Posle ažuriranja po referenci gde se modifikuju polja {0}", nameof(kompl) );
        Console.WriteLine("Kompleksni broj {0} =  {1} + i {2}", nameof(kompl),
            kompl.GetRe(), kompl.GetIm());

        AlgebarskiKompleksni.Azuriraj3(kompl);
        Console.WriteLine("Posle \"normalnog\" ažuriranja gde se menja ceo objekat {0}", nameof(kompl));
        Console.WriteLine("Kompleksni broj {0} =  {1} + i {2}", nameof(kompl),
            kompl.GetRe(), kompl.GetIm());

        AlgebarskiKompleksni.Azuriraj4(ref kompl);
        Console.WriteLine("Posle ažuriranja po referenci gde se menja ceo objekat {0}", nameof(kompl));
        Console.WriteLine("Kompleksni broj {0} =  {1} + i {2}", nameof(kompl),
            kompl.GetRe(), kompl.GetIm());
    }
}

/* Izlaz dobijen prilikom izvršavanja programa:
 
Kompleksni broj kompl =  2 + i 4
Posle "normalnog" ažuriranja gde se modifikuju polja kompl
Kompleksni broj kompl =  7 + i 9
Posle ažuriranja po referenci gde se modifikuju polja kompl
Kompleksni broj kompl =  12 + i 14
Posle "normalnog" ažuriranja gde se menja ceo objekat kompl
Kompleksni broj kompl =  12 + i 14
Posle ažuriranja po referenci gde se menja ceo objekat kompl
Kompleksni broj kompl =  1 + i 2

*/