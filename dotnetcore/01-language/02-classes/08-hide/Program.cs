
using System;

namespace RS2.MethodNewHide
{
    // roditeljska klasa 
    public class Roditelj
    {
        public void PrikaziSe()
        {
            Console.WriteLine("Ja sam primerak klase Roditelj.");
        }
    }

    // izvedena klasa 
    public class Potomak : Roditelj
    {
        public new void PrikaziSe()
        {
            Console.WriteLine("Ja sam primerak klase Potomak.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            //obj = new Roditelj();
            //obj.PrikaziSe();

            //obj = new Potomak();
            //obj.PrikaziSe();

            //Potomak obj2 = new Potomak();
            //obj2.PrikaziSe();

            Potomak obj2 = new Potomak();
            obj2.PrikaziSe();

            Roditelj obj = obj2;
            obj.PrikaziSe();

        }

    }
}
