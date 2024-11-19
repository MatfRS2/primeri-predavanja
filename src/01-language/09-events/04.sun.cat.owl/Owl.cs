using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2.SunCatOwl
{
    public class Owl
    {
        public static void OnSunRaised(object sender, SunRiseEventArgs e)
        {
            Console.WriteLine("O>" + "I am am going to sleep at " + e.RaisingTime + ". Hoooh!");
        }

        public static void OnSunDeclined(object sender, SunDeclineEventArgs e)
        {
            Console.WriteLine("O>" + "I am going to hunt at " + e.DecliningTime + ". Hoooh!");
        }
    }

}
