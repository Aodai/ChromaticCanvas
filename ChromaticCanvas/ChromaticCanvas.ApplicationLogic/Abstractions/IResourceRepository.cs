using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.Abstractions
{
    public interface IResourceRepository : IRepository<Resource>
    {
       Resource GetResourceById(Guid id);
        
    }
}
