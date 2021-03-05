using System;
using System.Linq;
using static ObserverPattern.Publisher.MymensinghNewsPublisher;

namespace ObserverPattern.Publisher
{
    public static class NewsPublisherFactory
    {
        public static NewsPublishingEventHandlerDelegate PrepareSubscribers(NewsPublishingEventHandlerDelegate onNewsPublished)
        {
            var subscriberType = typeof(INewsObserver);
            var subscribers = subscriberType.Assembly.ExportedTypes
                .Where(t => subscriberType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .Select(t => Activator.CreateInstance(t))
                .Cast<INewsObserver>()
                .ToList();

            foreach (var subscriber in subscribers)
            {
                onNewsPublished += subscriber.Observe;
            }

            return onNewsPublished;
        }
    }
}
