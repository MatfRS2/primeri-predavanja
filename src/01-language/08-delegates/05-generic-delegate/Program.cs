﻿
using System;

namespace RS2.GenericDelegate
{
    public delegate T Dodaj<T>(T param1, T param2); // generic delegate

    class Program
    {
        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
        public static double SumSquared(double val1, double val2)
        {
            return val1*val1 + val2*val2;
        }

        static void Main(string[] args)
        {
            Dodaj<int> sum = Sum;
            Console.WriteLine(sum(10, 20));

            Dodaj<string> con = Concat;
            Console.WriteLine(con(con("Miki", " "), "Maus"));

            Dodaj<double> sum2 = SumSquared;
            Console.WriteLine(sum2(10, 20));
        }

     }
}

