using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern_New
{
    class Zelle : Subject
    {
        private int m_iWert;

        public Zelle(int wert)
        {
            m_iWert = wert;
            observers = new List<IObserver>();
        }

        public int getWert()
        {
            return m_iWert;
        }

        public void setZustand(int wert)
        {
            m_iWert = wert;
            aktualisiere();
        }
    }
}
