using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2.SimpleIndexer
{
    public static class NiskeProsirenje
    {
        public static void Prikazi(this Niske elementi)
        {
            for (int i = 0; i < elementi.Dimenzija; i++)
                Console.WriteLine(elementi[i]);
            Console.WriteLine("---");
        }
    }
}
