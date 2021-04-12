using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.Abstractions
{
    public interface IEventRepository : IRepository<Event>
    {
        Event GetEventById(Guid eventID);
    }
}
