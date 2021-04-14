using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.Abstractions
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        Payment GetPaymentById(Guid id);
    }
}
