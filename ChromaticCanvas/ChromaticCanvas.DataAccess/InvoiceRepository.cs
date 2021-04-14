using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Linq;

namespace ChromaticCanvas.DataAccess
{
    public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(ChromaticCanvasDbContext dbContext) : base(dbContext) { }
        public Invoice GetInvoiceById(Guid id)
        {
            return dbContext.Invoices
                .Where(invoice => invoice.ID == id).SingleOrDefault();
        }
    }
}
