using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using System;

namespace ChromaticCanvas.ApplicationLogic.Services
{
    public class ResourcesService
    {
        private IResourceRepository resourceRepository;

        public ResourcesService(IResourceRepository resourceRepository)
        {
            this.resourceRepository = resourceRepository;
        }

        public Resource GetResourceById(string id)
        {
            Guid resourceGuid = Guid.Empty;
            if (!Guid.TryParse(id, out resourceGuid))
                throw new Exception("Invalid Guid format");

            var resource = resourceRepository.GetResourceById(resourceGuid);
            if (resource == null)
                throw new EntityNotFoundException(resourceGuid);

            return resource;
        }
    }
}
