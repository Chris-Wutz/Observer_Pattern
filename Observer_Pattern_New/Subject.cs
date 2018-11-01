using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern_New
{
    abstract class Subject
    {
        protected List<IObserver> observers { get; set; }

        public void anmelden(IObserver o)
        {
            observers.Add(o);
        }

        public void abmelden(IObserver o)
        {
            observers.Remove(o);
        }

        public void aktualisiere()
        {
            foreach (IObserver o in observers)
            {
                o.update();
            }
        }
    }
}
