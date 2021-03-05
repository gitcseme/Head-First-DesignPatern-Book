using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ObserverPattern.Publisher
{
    public class MymensinghNewsPublisher
    {
        public delegate void NewsPublishingEventHandlerDelegate(object source, NewsEventArgs args);
        public event NewsPublishingEventHandlerDelegate OnNewsPublished;

        public void PublishNews(News news)
        {
            Console.WriteLine("News is preparing to publish...\n");
            Thread.Sleep(3000);

            OnNewsPublished = NewsPublisherFactory.PrepareSubscribers(OnNewsPublished);

            //if (OnNewsPublished != null)
            //{
            //    OnNewsPublished(this, new NewsEventArgs { News = news });
            //}

            OnNewsPublished?.Invoke(this, new NewsEventArgs { News = news });
        }
    }
}
