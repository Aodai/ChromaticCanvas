using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChromaticCanvas.DataAccess
{
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ChromaticCanvasDbContext dbContext) : base(dbContext) { }
        public Payment GetPaymentById(Guid id)
        {
            return dbContext.Payments
                .Where(payment => payment.ID == id).FirstOrDefault();
        }
    }
}
