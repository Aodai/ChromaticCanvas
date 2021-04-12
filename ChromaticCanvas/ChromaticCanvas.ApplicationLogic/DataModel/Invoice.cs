using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.DataModel
{
    public class Invoice
    {
        public Guid ID { get; set; }
        public Decimal Amount { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
