﻿/*

Opcioni parametri

U definicиji funkcije tj. metoda (kao i konstruktora, indeksera ili delegata) se 
njegovi parametri mogu specificrati kao obavezni ili kao opcioni. 
Poziv funkcije mora obezbediti sve obavezne parametre, ali opcioni prametri 
mogu da  ne budu specificirani - tada se u supstituciji koristi njihova 
podrazumevana vrednost.
Naime, svaki opcioni parametar ima podrazimevanu vrednost u okviru svoje
definicije, pa ako vrednost argumenta za taj parametar nije specificirana u
pozivu, koristiće se ta podrazumevana vrednost. 
Opcioni parametri su definisani na karju liste parametara, posle svih 
obaveznih.
Aкo se pri pozivu obezbeđuje vrednost za neki opcioni parmetar, potrebno je 
obezbediti vrednosti za sve opcione parametre koji mu prethode.

Imenovani argumenti

Imenovani argumenti oslobađaju obaveze uklapanja redosleda argumenata pri 
pozivu sa redosledom parametara u definiciji metoda. 
Informacija na koji se parametar odnosi dati argument se može dati u pozivu
metoda tako što se specificira ime parametra.
Imenovani argumenti pobiljšavaju čitljivost programskog koda, tako što se 
lakše identifikuje šta predstavlja koji argument.
Kada se imenovani argumenti koriste zajedno sa pozicionim argumentima, tada
pozicioni arumenti ne mogu da budu posle imenovanih, i oni moraju da budu na 
svom mestu. 

*/

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
            Console.WriteLine("Puno ime: {0} {1}", ime, prezime);
            Console.WriteLine("Uzrast:   {0}", age);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            prikazOdDo(35, 40);
            prikazOdDo();
            Console.WriteLine("---");

            prikazOdDo(zakljucno: 35, pocev: 40);
            prikazOdDo(zakljucno:35);
            Console.WriteLine("---");

            StampajViseLinija(3);
            StampajViseLinija();
            Console.WriteLine("---");

            int z = BrojSlova("123 Petar Petrović 123");
            Console.WriteLine(z);
            Console.WriteLine(Nalepi("Petar Petrović ", 4));
            Console.WriteLine(Nalepi("Janko Janković "));
            Console.WriteLine(Nalepi(brojPonavljanja:3, niska: "Marko Marković "));
            Console.WriteLine("---");

            Prikaz2("Jovan", 90, "Jovanović");
            Prikaz2("Žarko", 95);
            Prikaz2("Marko");
            Prikaz2();
            Prikaz2(prezime: "Jovanović", ime: "Jovan");
            Prikaz2(prezime: "Ivanović");
            Console.WriteLine("---");
        }
    }
}

/* Izlaz dobijen prilikom izvršavanja programa:
35
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
12
Petar Petrović Petar Petrović Petar Petrović Petar Petrović
Janko Janković Janko Janković
Marko Marković Marko Marković Marko Marković
---
Puno ime: Jovan Jovanović
Uzrast:   90
Puno ime: Žarko Marković
Uzrast:   95
Puno ime: Marko Marković
Uzrast:   20
Puno ime: Marko Marković
Uzrast:   20
Puno ime: Jovan Jovanović
Uzrast:   20
Puno ime: Marko Ivanović
Uzrast:   20
---
---
 */