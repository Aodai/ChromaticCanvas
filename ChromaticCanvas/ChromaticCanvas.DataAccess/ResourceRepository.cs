
using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Linq;

namespace ChromaticCanvas.DataAccess
{
    public class ResourceRepository : BaseRepository<Resource>, IResourceRepository
    {
        public ResourceRepository(ChromaticCanvasDbContext dbContext) : base(dbContext)
        { }
        public Resource GetResourceById(Guid id)
        {
            return dbContext.Resources
                .Where(resource=>resource.ID==id).SingleOrDefault();
        }
    }
}
