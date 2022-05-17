using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public class NewspaperA : ISubscriber
    {
        public void NotifyNewsToEndUsers(string news)
        {
            Console.WriteLine($"EXTRA, EXTRA! {news}");
        }
    }
}
