using ChromaticCanvas.ApplicationLogic.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace ChromaticCanvas.DataAccess
{
    public class BaseRepository<T>  : IRepository<T> where T : class, new()
    {
        protected readonly ChromaticCanvasDbContext dbContext;

        public BaseRepository(ChromaticCanvasDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public T Add (T item)
        {
            var entity = dbContext.Add<T>(item);
            dbContext.SaveChanges();
            return entity.Entity;
        }

        public bool Delete(T item)
        {
            dbContext.Remove<T>(item);
            dbContext.SaveChanges();
            return true;
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>()
                            .AsEnumerable();
        }

        public T Update(T item)
        {
            var entity = dbContext.Update<T>(item);
            dbContext.SaveChanges();
            return entity.Entity;
        }
    }
}
