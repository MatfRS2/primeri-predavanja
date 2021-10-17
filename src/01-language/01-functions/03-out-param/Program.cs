using System;

namespace RS2.OutParams
{
    class Program
    {
         static void PostaviDuplirajVrednosti(out int x, out int y)
        {
            x = 5;
            y = 10;
            x += x;
            y += y;
        }

     
        static void Main(string[] args)
        {
            // variables are declared, but not initialized
            int a, b;

            PostaviDuplirajVrednosti(out a, out b);
            // Display initial values 
            Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(a), a);
            Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(b), b);
            Console.WriteLine();

            PostaviDuplirajVrednosti(out int c, out int d);
            Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(c), c);
            Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(d), d);
            Console.WriteLine();
        }

    }
}