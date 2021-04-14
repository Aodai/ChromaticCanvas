using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using System;

namespace ChromaticCanvas.ApplicationLogic.Services
{
    public class BookingsService
    {
        private IBookingRepository bookingRepository;

        public BookingsService(IBookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }

        public Booking GetBookingById(string id)
        {
            Guid bookingGuid = Guid.Empty;
            if (!Guid.TryParse(id, out bookingGuid))
                throw new Exception("Invalid Guid format");

            var booking = bookingRepository.GetBookingById(bookingGuid);
            if (booking == null)
                throw new EntityNotFoundException(bookingGuid);

            return booking;
        }
    }
}
