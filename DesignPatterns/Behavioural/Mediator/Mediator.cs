using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioural.Mediator
{
    public class Mediator
    {
        private Presenter _presenter;
        private List<Attendee> _attendees;


        public void AddAttendees(Attendee attendee)
        {

            if (_attendees == null)
            {
                _attendees = new List<Attendee> { attendee };
            }
            else
            {
                _attendees.Add(attendee);
            }
        }

        public int GetNumberOfAttendees() => _attendees.Count;

        public void SetPresenter (Presenter presenter) => _presenter = presenter;        

        internal void NotifyImageUpdate(string fakeImageName)
        {
            foreach(var attendee in _attendees)
            {
                attendee.NotifyImageUpdate(fakeImageName);
            }
        }
    }
}
