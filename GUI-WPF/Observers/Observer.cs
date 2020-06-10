using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_WPF.Observers;

namespace GUI_WPF.Observers
{
    public class Observer : IObserver
    {
        List<IObserver> observers;
        public Observer()
        {
            observers = new List<IObserver>();
        }
        public void update(string message)
        {
            //observers.Add(new List<IObserver>(message));    //Får den inte att funka
        }
    }
}
