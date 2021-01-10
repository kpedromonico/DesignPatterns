using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using DesignPatterns.Behavioural.Mediator;

using Mediatr = DesignPatterns.Behavioural.Mediator.Mediator;

namespace DesignPatterns.Tests.Behavioural.Mediator
{

    /*
        This pattern implementation should:
        * Have a presenter which can updates an image and that should be notified to all attendees of the presentation.        
     */

    public class MediatorUnitTests
    {

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        public void Mediator_AddAttendees_IncreaseTheNumberOfAttendees(int totalAttendees)
        {
            // Arrange
            Mediatr mediator = new Mediatr();            

            // Act
            for(int i = 0; i < totalAttendees; i++)
            {
                Attendee attendee = new Attendee(mediator);
                mediator.AddAttendees(attendee);
            }

            // Assert
            Assert.Equal(totalAttendees, mediator.GetNumberOfAttendees());
        }

        [Fact]
        public void Mediator_WhenPresenterUpdatesImage_AttendeeMustReceive()
        {
            // Arrange
            Mediatr mediator = new Mediatr();
            Presenter presenter = new Presenter(mediator);
            Attendee attendee = new Attendee(mediator);

            string fakeImageName = "test-image.png";

            // Act
            mediator.AddAttendees(attendee);
            presenter.UpdateImage(fakeImageName);

            // Assert            
            Assert.Equal(fakeImageName, attendee.MyActualImage);
        }

    }
}
