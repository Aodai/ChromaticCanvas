using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.DataModel
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public ApplicationUser User { get; set; }
        public bool Active { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
