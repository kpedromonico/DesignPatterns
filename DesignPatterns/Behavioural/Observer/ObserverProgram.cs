using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public static class ObserverProgram
    {
        // DEF:
        // Defines a one-to-many relationship between objects so taht when one object changes state
        // all its dependents are notified and updated automatically.
        public static async Task Run()
        {
            IPublisher publisher = new FieldReporter();
            publisher.Subscribe(new ChannelA());
            publisher.Subscribe(new NewspaperA());

            var taskA = Task.Run(async () =>
            {
                await Task.Delay(1000);
                publisher.DeliverNews("New tesla car announced");
            });

            var taskB = Task.Run(() => publisher.DeliverNews("War in Krimea"));
            
            await Task.WhenAll(taskA, taskB)
                .ContinueWith(delegate { Console.WriteLine("Finished."); });

        }
    }
}
