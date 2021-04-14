using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;

namespace ChromaticCanvas.ApplicationLogic.Abstractions
{
    public interface IAttendeeRepository : IRepository<Attendee>
    {
        List<Attendee> GetAttendeesByEventId(Guid id);
    }
}
