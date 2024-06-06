using Models;
using Services;

namespace Controllers
{
    public class PaymentController
    {
        private PaymentService _paymentService;

        public PaymentController()
        {
            _paymentService = new PaymentService();
        }

        public bool InsertPayment(Payment payment)
        {
            return _paymentService.InsertPayment(payment);
        }
    }
}