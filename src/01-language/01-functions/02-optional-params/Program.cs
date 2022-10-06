
using System;
using System.Text;

namespace RS2.Funkcije.OpcionalniImenovaniParametri
{
    class Program
    {
        static void prikazOdDo(int pocev = 40, int zakljucno = 42)
        {
            int i = pocev;
            while (i <= zakljucno)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void StampajViseLinija(int brojLinija = 2)
        {
            for (int i = 0; i < brojLinija; i++)
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

        static string Nalepi(string niska, int brojPonavljanja = 2)
        {
            if (brojPonavljanja <= 1)
                return niska;
            StringBuilder graditelj = new StringBuilder(niska);
            for (int i = 1; i < brojPonavljanja; i++)
            {
                graditelj.Append(niska);
            }
            return graditelj.ToString();
        }

        static public void Prikaz2(string ime = "Marko", int age = 20,
            string prezime = "Marković")
        {
            Console.WriteLine("Full name: {0} {1}", ime, prezime);
            Console.WriteLine("Age: {0}", age);
        }

        static void Main(string[] args)
        {
            prikazOdDo(35, 40);
            prikazOdDo();
            Console.WriteLine("---");

            prikazOdDo(zakljucno: 35, pocev: 40);
            prikazOdDo(zakljucno:35);
            Console.WriteLine("---");

            StampajViseLinija(3);
            StampajViseLinija();
            Console.WriteLine("---");

            int z = BrojSlova("123 Miki Maus 123");
            Console.WriteLine(z);
            Console.WriteLine(Nalepi("Miki Maus ", 4));
            Console.WriteLine(Nalepi("Paja Patak "));
            Console.WriteLine(Nalepi(brojPonavljanja:3, niska: "Raja Patak "));
            Console.WriteLine("---");

            Prikaz2("Baja", 90, "Patak");
            Prikaz2("Miki", 95);
            Prikaz2("Baja");
            Prikaz2();
            Prikaz2(prezime: "Patak", ime: "Paja");
            Prikaz2(prezime: "Patak");
            Console.WriteLine("---");
        }
    }
}

/* Izlaz dobijen prilikom izvršavanja programa:


36
37
38
39
40
40
41
42
---
---
-- 0 --
-- 1 --
-- 2 --
-- 0 --
-- 1 --
---
8
Miki Maus Miki Maus Miki Maus Miki Maus
Paja Patak Paja Patak
Raja Patak Raja Patak Raja Patak
---
Full name: Baja Patak
Age: 90
Full name: Miki Markovic
Age: 95
Full name: Baja Markovic
Age: 20
Full name: Marko Markovic
Age: 20
Full name: Paja Patak
Age: 20
Full name: Marko Patak
Age: 20
---
 */