using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.Abstractions
{
    public interface ISubscriptionRepository : IRepository<Subscription>
    {
        // TODO: Figure out what to put in here or maybe redefine the subscriptions entity to have a unique identifier.
    }
}
