namespace DesignPatterns.Behavioural.Observer
{
    public class FieldReporter : IPublisher
    {
        private List<ISubscriber> _subscribers = default!;

        public void DeliverNews(string news)
        {
            Console.WriteLine("Report sent some news...");
            _subscribers.ForEach(x => x.NotifyNewsToEndUsers(news));
            Console.WriteLine("--------");
        }

        public void Subscribe(ISubscriber subscriber)
        {
            if (_subscribers == null)
            {
                _subscribers = new List<ISubscriber>();
            }

            if (!_subscribers.Any(x => x == subscriber))
            {
                _subscribers.Add(subscriber);
            }
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            if (!_subscribers.Any(x => x == subscriber))
            {
                _subscribers.Remove(subscriber);
            }
        }
    }
}
