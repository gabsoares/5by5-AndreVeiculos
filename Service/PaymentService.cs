using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class PaymentService
    {
        private IPaymentRepository _paymentRepository;

        public PaymentService()
        {
            _paymentRepository = new PaymentRepository();
        }

        public bool InsertPayment(Payment payment)
        {
            return _paymentRepository.InsertPayment(payment);
        }
    }
}