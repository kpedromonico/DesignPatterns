using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioural.Mediator
{
    public class Presenter : PresentationMember
    {
        public Presenter(Mediator mediator) : base(mediator) { }

        public void UpdateImage(string fakeImageName)
        {
            _mediator.NotifyImageUpdate(fakeImageName);
        }
    }
}
