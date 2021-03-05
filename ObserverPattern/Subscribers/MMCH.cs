using ObserverPattern.Publisher;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Subscribers
{
    public class MMCH : INewsObserver
    {
        public void Observe(object source, NewsEventArgs args)
        {
            Console.WriteLine("MMCH today's news: ");
            Console.WriteLine("-------------------");
            Console.WriteLine($" {args.News.Title}\n {args.News.Description}\n\n");
        }
    }
}
