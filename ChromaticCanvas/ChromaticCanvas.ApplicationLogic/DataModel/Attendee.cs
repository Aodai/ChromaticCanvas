using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.DataModel
{
    public class Attendee
    {
        public Event Event { get; set; }
        public Member User { get; set; }
    }
}
