using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using System;

namespace ChromaticCanvas.ApplicationLogic.Services
{
    public class InvoicesService
    {
        private IInvoiceRepository invoiceRepository;

        public InvoicesService(IInvoiceRepository invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
        }

        public Invoice GetInvoiceById(string id)
        {
            Guid invoiceGuid = Guid.Empty;
            if (!Guid.TryParse(id, out invoiceGuid))
                throw new Exception("Invalid Guid format");

            var invoice = invoiceRepository.GetInvoiceById(invoiceGuid);
            if (invoice == null)
                throw new EntityNotFoundException(invoiceGuid);

            return invoice;
        }
    }
}
