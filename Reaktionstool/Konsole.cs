using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaktionstool
{
    class Konsole
    {
        public void start()
        {
            Console.WriteLine("Spiel gestartet!");
            Console.WriteLine();
        }

        public void ausgabe(int _timer)
        {
            Console.WriteLine("Countdown:    " + _timer);
            Console.Clear();
        }

        public void tastendruck()
        {
            Console.ReadKey();
           return true;
        }

        public void ergebnis(double _result/*, int _score*/)
        {
            Console.WriteLine("Dein Ergebnis: " + _result + " Sekunden");
            //Console.WriteLine("Dein Score:    " + _score);
            Console.ReadKey();

        }
    }
}
