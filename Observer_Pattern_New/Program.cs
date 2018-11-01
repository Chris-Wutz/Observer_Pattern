using System;

namespace Observer_Pattern_New
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zellen, Zahlen, ... anlegen

            Zelle oFeld1 = new Zelle(3);

            Zelle oFeld2 = new Zelle(4);

            Summe oSumme = new Summe(oFeld1, oFeld2);

            // Im Konstruktor der Summe meldet sich die Summe bei den beteiligten Zellen an
            //    und es wird schon die erste Summe am Bildschirm ausgegeben. Summe: 7

            oFeld1.setZustand(2);
            // Jetzt wird die zweite (geänderte) Summe am Bildschirm ausgegeben.

            // Summe: 6

            Console.ReadKey();
        }
    }
}
