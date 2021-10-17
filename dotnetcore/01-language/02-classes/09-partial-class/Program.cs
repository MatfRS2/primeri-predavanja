
using System;

namespace RS2.PartiallClass
{
    public partial class Program
    {
        static void StampajViseLinija(int z)
        {
            for (int i = 0; i < z; i++)
                Console.WriteLine("-- " + i + " --");
        }

        public static void Main(string[] args)
        {
            prikazDo42();
            int z = 2;
            StampajViseLinija(z);
            Console.WriteLine("Hello World!");
            StampajViseLinija(z);
        }

    }
}
