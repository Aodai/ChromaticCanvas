using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Linq;

namespace ChromaticCanvas.DataAccess
{
    public class BookingRepository : BaseRepository<Booking>, IBookingRepository
    {
        public BookingRepository(ChromaticCanvasDbContext dbContext) : base(dbContext)
        { }
        public Booking GetBookingById(Guid id)
        {
            return dbContext.Bookings
                .Where(booking => booking.ID == id).SingleOrDefault();
        }
    }
}
