﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern_New
{
    class Produkt : IObserver
    {
        private Zelle z1;
        private Zelle z2;

        public Produkt(Zelle zelle1, Zelle zelle2)
        {
            z1 = zelle1;
            z2 = zelle2;

            z1.anmelden(this);
            z2.anmelden(this);

            ersteBenachrichtigung();
        }

        public void ersteBenachrichtigung()
        {
            Console.WriteLine("Das erst Produkt beträgt: " + (z1.getWert() * z2.getWert()));
            Console.WriteLine();
        }

        public void update()
        {
            Console.WriteLine("Die aktualisiete Produkt nach setzen eines neuen Wertes beträgt: " + (z1.getWert() * z2.getWert()));
            Console.WriteLine();
        }
    }
}
