using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.DataAccess
{
    public class SubscriptionRepository : BaseRepository<Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(ChromaticCanvasDbContext dbContext) : base(dbContext) { }
    }
}
