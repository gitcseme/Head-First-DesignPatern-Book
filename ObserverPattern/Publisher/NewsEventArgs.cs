using System;

namespace ObserverPattern.Publisher
{
    public class NewsEventArgs : EventArgs
    {
        public News News { get; set; }
    }
}
