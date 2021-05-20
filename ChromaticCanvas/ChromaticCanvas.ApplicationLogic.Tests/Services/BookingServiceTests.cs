using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using ChromaticCanvas.ApplicationLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromaticCanvas.ApplicationLogic.Tests.Services
{
    [TestClass]
    public class BookingServiceTests
    {
        private Mock<IBookingRepository> bookingRepoMock = new Mock<IBookingRepository>();
        private Guid existingBookingId = Guid.NewGuid();

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
                ID = Guid.NewGuid(),
                Organizer = user,
                Name = "Graduation",
                StartDate = DateTime.Parse("1/1/2021 18:00:00"),
                EndDate = DateTime.Parse("1/1/2021 22:00:00")
            };

            var booking = new Booking
            {
                ID = existingBookingId,
                Event = eventt,
                Resource = null
            };

            bookingRepoMock.Setup(bookingRepo => bookingRepo.GetBookingById(existingBookingId)).Returns(booking);
        }

        [TestMethod]
        public void GetBookingById_ThrowsException_WhenBookingIdHasInvalidValue()
        {
            var bookingService = new BookingsService(bookingRepoMock.Object);

            var badId = "asdjlkasdklas sakld askld";

            Assert.ThrowsException<Exception>(() =>
            {
                bookingService.GetBookingById(badId);
            });
        }

        [TestMethod]
        public void GetBookingById_ThrowsEntityNotFound_WhenBookingDoesNotExist()
        {
            var nonExistingId = Guid.NewGuid();
            var bookingService = new BookingsService(bookingRepoMock.Object);

            Assert.ThrowsException<EntityNotFoundException>(() =>
            {
                bookingService.GetBookingById(nonExistingId.ToString());
            });
        }

        [TestMethod]
        public void GetBookingById_Returns_BookingWhenExists()
        {
            Exception throwException = null;
            var bookingService = new BookingsService(bookingRepoMock.Object);
            Booking booking = null;

            try
            {
                booking = bookingService.GetBookingById(existingBookingId.ToString());
            }
            catch (Exception e)
            {
                throwException = e;
            }

            Assert.IsNull(throwException, $"Exception was thrown");
            Assert.IsNotNull(booking);
        }
    }
}
