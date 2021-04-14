using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using System;

namespace ChromaticCanvas.ApplicationLogic.Services
{
    public class SubscriptionsService
    {
        private ISubscriptionRepository subscriptionRepository;

        public SubscriptionsService(ISubscriptionRepository subscriptionRepository)
        {
            this.subscriptionRepository = subscriptionRepository;
        }
    }
}
