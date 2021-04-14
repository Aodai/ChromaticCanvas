using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using System;

namespace ChromaticCanvas.ApplicationLogic.Services
{
    public class PaymentsService
    {
        private IPaymentRepository paymentRepository;

        public PaymentsService(IPaymentRepository paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }

        public Payment GetPaymentById(string id)
        {
            Guid paymentGuid = Guid.Empty;

            if (!Guid.TryParse(id, out paymentGuid))
                throw new Exception("Invalid Guid format");

            var payment = paymentRepository.GetPaymentById(paymentGuid);
            if (payment == null)
                throw new EntityNotFoundException(paymentGuid);

            return payment;
        }
    }
}
