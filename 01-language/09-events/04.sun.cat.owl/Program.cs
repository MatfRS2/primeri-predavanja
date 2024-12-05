using System;
using System.Threading;

namespace RS2.SunCatOwl
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Sun sun = new Sun();
            // registruj rukovaoce za dogadjaj izlaska sunca
            sun.SunRised += Cat.OnSunRaised;
            sun.SunRised += Owl.OnSunRaised;
            // registruj rukovaoce za dogadjaj zalaska sunca
            sun.SunDeclined += Cat.OnSunDeclined;
            sun.SunDeclined += Owl.OnSunDeclined;
            sun.StartProcess();
        }
    }
}