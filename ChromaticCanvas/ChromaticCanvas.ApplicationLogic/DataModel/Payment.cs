using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.DataModel
{
    public class Payment
    {
        public Guid ID { get; set; }
        public Member User { get; set; }
        public Invoice Invoice { get; set; }
        public DateTime Date { get; set; }
        public Decimal Amount { get; set; }
    }
}
