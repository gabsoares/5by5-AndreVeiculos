using Models;

namespace Repositories.Interface
{
    public interface IPurchaseRepository
    {
        bool InsertPurchase(Purchase purchase);
    }
}
