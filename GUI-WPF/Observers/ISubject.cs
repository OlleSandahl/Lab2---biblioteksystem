namespace GUI_WPF.Observers
{
    interface ISubject
    {
        void notifyObserver(string message);
        void registerObserver(IObserver observer);
       // void unregisterObserver(IObserver observer);
    }
}