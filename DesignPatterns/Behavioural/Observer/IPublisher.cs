using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioural.Observer
{
    public interface IPublisher
    {
        void Subscribe(ISubscriber subscriber);

        void Unsubscribe(ISubscriber subscriber);

        void DeliverNews(string news);
    }
}
