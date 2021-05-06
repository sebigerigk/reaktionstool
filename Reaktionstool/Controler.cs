using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Reaktionstool
{
    class Controler
    {
        public void zaehler()
        {
            int sec = 3;
            Konsole console = new Konsole();
            console.start();

            while (sec >= 0)
            {
                console.ausgabe(sec);
                Thread.Sleep(1000);
                sec--;
            }

            DateTime start = DateTime.Now;
            console.tastendruck();
            DateTime end = DateTime.Now;
            
            console.ergebnis(double(DateTime time = end - start));
            
        }
    }
}
