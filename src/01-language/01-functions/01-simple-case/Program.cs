
using System;
using System.Text;

namespace RS2.Funkcije.Jednostavno
{
    class Program
    {
        static void PrikazDo42()
        {
            int i = 40;
            while (i <= 42)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void StampajViseLinija(int z)
        {
            for (int i = 0; i < z; i++)
                Console.WriteLine("-- " + i + " --");
        }

        static int BrojSlova(string s)
        {
            int ret = 0;
            foreach (char ch in s)
            {
                if (ch >= 'a' && ch <= 'z')
                    ret++;
                if (ch >= 'A' && ch <= 'Z')
                    ret++;
            }
            return ret;
        }

        static string Nalepi(string s, int brojPonavljanja)
        {
            if (brojPonavljanja <= 1)
                return s;
            StringBuilder graditelj = new StringBuilder(s);
            for (int i = 1; i < brojPonavljanja; i++)
            {
                graditelj.Append(s);
            }
            return graditelj.ToString();
        }

        static void Main(string[] args)
        {
            PrikazDo42();
            Console.WriteLine();

            int z = 2;
            StampajViseLinija(z);
            Console.WriteLine("Zdravo svete!");
            StampajViseLinija(z);
            Console.WriteLine();

            z = BrojSlova("123 Miki Maus 123");
            Console.WriteLine(z);
            Console.WriteLine(Nalepi("Miki Maus ", 2));
            Console.WriteLine(Nalepi(brojPonavljanja: 4, s: "Paja Patak "));
            Console.WriteLine();
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
40
41
42

-- 0 --
-- 1 --
Zdravo svete!
-- 0 --
-- 1 --

8
Miki Maus Miki Maus
Paja Patak Paja Patak Paja Patak Paja Patak

*/

