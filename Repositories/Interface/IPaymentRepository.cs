using Models;

namespace Repositories.Interface
{
    public interface IPaymentRepository
    {
        bool InsertPayment(Payment payment);
    }
}
