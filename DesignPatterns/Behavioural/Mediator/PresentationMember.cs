using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioural.Mediator
{
    public abstract class PresentationMember
    {
        protected Mediator _mediator;

        public PresentationMember(Mediator mediator)
        {
            this._mediator = mediator;
        }        
    }
}
