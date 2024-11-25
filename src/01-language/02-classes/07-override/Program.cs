
using System;

namespace RS2.MethodOverride
{
    // roditeljska klasa 
    public class Roditelj
    {
        public virtual void PrikaziSe()
        {
            Console.WriteLine("Ja sam primerak klase Roditelj.");
        }
    }

    // izvedena klasa 
    public class Potomak : Roditelj
    {
        // overrided method 
        public override void PrikaziSe()
        {
            Console.WriteLine("Ja sam primerak klase Potomak.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Roditelj obj;

            obj = new Roditelj();
            obj.PrikaziSe();

            obj = new Potomak();
            obj.PrikaziSe();
        }

    }
}
