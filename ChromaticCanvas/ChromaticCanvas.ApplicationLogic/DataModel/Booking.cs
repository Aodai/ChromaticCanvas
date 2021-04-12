using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.DataModel
{
    public class Booking
    {
        public Guid ID { get; set; }
        public Event Event { get; set; }
        public Resource Resource { get; set; }
    }
}
