
using System;

namespace RS2.Atributi
{
    [Serializable]
    public class Roditelj
    {
        public void PrikaziSe()
        {
            Console.WriteLine("Ja sam primerak klase Roditelj.");
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Roditelj obj;

            obj = new Roditelj();
            obj.PrikaziSe();

        }

    }
}
