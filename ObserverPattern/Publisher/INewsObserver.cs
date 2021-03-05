namespace ObserverPattern.Publisher
{
    public interface INewsObserver
    {
        void Observe(object source, NewsEventArgs args);
    }
}
