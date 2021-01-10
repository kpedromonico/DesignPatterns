using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioural.Mediator
{
    public class Attendee : PresentationMember
    {
        public string MyActualImage { get; set; }

        public Attendee(Mediator mediator) : base(mediator) { }

        public void NotifyImageUpdate(string ImageName)
        {
            // Instead of storing this in a variable we could just print on the console or whatever
            // But for the sake of the tests and it is just to prove the capabilities of the pattern
            // i'm storing this in a variable
            MyActualImage = ImageName;            
        }
    }
}
