using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2.SunCatOwl
{
    public class Cat
    {
        public static void OnSunRaised(object sender, SunRiseEventArgs e)
        {
            Console.WriteLine("C>" + "I am wake at " + e.RaisingTime + ". Miaow!");
        }

        public static void OnSunDeclined(object sender, SunDeclineEventArgs e)
        {
            Console.WriteLine("C>" + "I am going to sleep at " + e.DecliningTime + ". Miaow!");
        }
    }
}
