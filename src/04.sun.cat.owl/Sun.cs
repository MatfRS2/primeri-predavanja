using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2.SunCatOwl
{
    public class SunRiseEventArgs : EventArgs
    {
        public DateTime RaisingTime { get; set; }
    }


    public class SunDeclineEventArgs : EventArgs
    {
        public DateTime DecliningTime { get; set; }
    }

    public class Sun
    {
        // deklarisanje dogadjaja
        public event EventHandler<SunRiseEventArgs> SunRised;
        public event EventHandler<SunDeclineEventArgs> SunDeclined;

        // metoda u okviru koje se ispaljuje dogadjaj
        public void StartProcess()
        {
            var dataRaise = new SunRiseEventArgs();
            var dataDecline = new SunDeclineEventArgs();
            try
            {
                Console.WriteLine("S: Program je pokrenut.");
                Thread.Sleep(200);
                Console.WriteLine("S: Sunce izlazi!");
                Thread.Sleep(500);
                // potom se ispaljuje dogadjaj izlaska sunca 
                Console.WriteLine("S: Ispali dogadjaj sunce izlazi!");
                dataRaise.RaisingTime = DateTime.Now.AddHours(-4);
                FireSunRaised(dataRaise);
                Console.WriteLine("S: Sun is travelling over sky...");
                Thread.Sleep(500);
                // potom se ispaljuje dogadjaj zalaska sunca 
                Console.WriteLine("S: Ispali dogadjaj sunce zalazi!");
                dataDecline.DecliningTime = DateTime.Now.AddHours(4);
                FireSunDeclined(dataDecline);
                Console.WriteLine("S: Program zavsava sa radom.");
            }
            catch (Exception ex)
            {
                dataDecline.DecliningTime = DateTime.Now;
                FireSunDeclined(dataDecline);
            }
        }

        // metod koji ispaljuje dogadjaj
        protected virtual void FireSunRaised(SunRiseEventArgs e)
        {
            if (SunRised != null)
                SunRised.Invoke(this, e);
        }

        // metod koji ispaljuje dogadjaj
        protected virtual void FireSunDeclined(SunDeclineEventArgs e)
        {
            if (SunDeclined != null)
                SunDeclined.Invoke(this, e);
        }
    }

}
