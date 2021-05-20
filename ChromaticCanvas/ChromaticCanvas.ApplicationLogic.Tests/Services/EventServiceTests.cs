using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using ChromaticCanvas.ApplicationLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace ChromaticCanvas.ApplicationLogic.Tests.Services
{
    [TestClass]
    public class EventServiceTests
    {
        private Mock<IEventRepository> eventRepoMock = new Mock<IEventRepository>();
        private Guid existingEventId = Guid.NewGuid();

        [TestInitialize]
        public void InitializeTest()
        {
            var user = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "bla",
                LastName = "bla",
                Email = "bla@bla.com"
            };

            var eventt = new Event
            {
                ID = existingEventId,
                Organizer = user,
                Name = "Graduation",
                StartDate = DateTime.Parse("1/1/2021 18:00:00"),
                EndDate = DateTime.Parse("1/1/2021 22:00:00")
            };

            eventRepoMock.Setup(eventRepo => eventRepo.GetEventById(existingEventId)).Returns(eventt);
        }

        [TestMethod]
        public void GetEventById_ThrowsException_WhenEventIdHasInvalidValue()
        {
            var eventService = new EventsService(eventRepoMock.Object);

            var badId = "asdjlkasdklas sakld askld";

            Assert.ThrowsException<Exception>(() =>
            {
                eventService.GetEventById(badId);
            });
        }

        [TestMethod]
        public void GetEventById_ThrowsEntityNotFound_WhenEventDoesNotExist()
        {
            var nonExistingId = Guid.NewGuid().ToString();
            var eventService = new EventsService(eventRepoMock.Object);

            Assert.ThrowsException<EntityNotFoundException>(() =>
            {
                eventService.GetEventById(nonExistingId);
            });
        }

        [TestMethod]
        public void GetEventById_Returns_EventWhenExists()
        {
            Exception throwException = null;
            var eventService = new EventsService(eventRepoMock.Object);
            Event eventt = null;
            
            try
            {
                eventt = eventService.GetEventById(existingEventId.ToString());
            }
            catch (Exception e)
            {
                throwException = e;
            }

            Assert.IsNull(throwException, $"Exception was thrown");
            Assert.IsNotNull(eventt);
        }
    }
}
