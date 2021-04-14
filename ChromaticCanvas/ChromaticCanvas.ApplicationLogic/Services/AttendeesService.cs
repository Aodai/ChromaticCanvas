using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;

namespace ChromaticCanvas.ApplicationLogic.Services
{
    public class AttendeesService
    {
        private IAttendeeRepository attendeeRepository;

        public AttendeesService(IAttendeeRepository attendeeRepository)
        {
            this.attendeeRepository = attendeeRepository;
        }
    }
}
