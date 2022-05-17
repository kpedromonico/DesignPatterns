using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public class ChannelA : ISubscriber
    {
        public void NotifyNewsToEndUsers(string news)
        {
            Console.WriteLine($"Channel A coming with some news... {news}!");
        }
    }
}
