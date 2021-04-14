using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.Abstractions
{
    public interface IBookingRepository : IRepository<Booking>
    {
        Booking GetBookingById(Guid id);
    }
}
