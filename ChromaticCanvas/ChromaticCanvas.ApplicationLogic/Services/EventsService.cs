using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using System;

namespace ChromaticCanvas.ApplicationLogic.Services
{
    public class EventsService
    {
        private IEventRepository eventRepository;

        public EventsService(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        public Event GetEventById(string eventId)
        {
            Guid eventGuid = Guid.Empty;
            if (!Guid.TryParse(eventId, out eventGuid))
                throw new Exception("Invalid Guid format");

            var eventt = eventRepository.GetEventById(eventGuid);
            if (eventt == null)
                throw new EntityNotFoundException(eventGuid);

            return eventt;
        }
    }
}
