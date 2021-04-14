using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Linq;

namespace ChromaticCanvas.DataAccess
{
   
        public class EventRepository : BaseRepository<Event>, IEventRepository
        {
            public EventRepository(ChromaticCanvasDbContext dbContext) : base(dbContext)
            { }
            public Event GetEventById(Guid id)
            {
                return dbContext.Events
                    .Where(eventt => eventt.ID == id).SingleOrDefault();
            }
        }
}

