using ObserverPattern.Publisher;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsToday = new News("Government Election", "Tomorrow is bangladesh government election which occurs in every 5 years periodically.");
            MymensinghNewsPublisher mymensinghNewsPublisher = new MymensinghNewsPublisher();
            mymensinghNewsPublisher.PublishNews(newsToday);
        }
    }
}
