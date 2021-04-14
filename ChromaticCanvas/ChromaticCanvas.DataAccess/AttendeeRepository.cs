using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChromaticCanvas.DataAccess
{
    public class AttendeeRepository : BaseRepository<Attendee>, IAttendeeRepository
    {
        public AttendeeRepository(ChromaticCanvasDbContext dbContext) : base(dbContext) { }

        public List<Attendee> GetAttendeesByEventId(Guid id)
        {
            return dbContext.Attendees
                .Where(eventt => eventt.Event.ID == id).ToList<Attendee>();
        }
    }
}
