using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_WPF.Observers
{
    class Subject : ISubject
    {
        IList<IObserver> observerss;
        private int observerIndex;

        public Subject()
        {
            observerss = new List<IObserver>();
        }

        public void notifyObserver(string message)
        {
            foreach (IObserver observers in observerss)
            {
                observers.update(message);
            }
        }

        public void registerObserver(IObserver observer)
        {
            observerss.Add(observer);
        }

        //public void unregisterObserver(IObserver observer)
        //{
        //    int observerIndex = observerss.IndexOf(observer);
        //    observerss.Remove(observerIndex);
        //}
    }
}
