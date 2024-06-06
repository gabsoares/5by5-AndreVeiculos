using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class PurchaseService
    {
        private IPurchaseRepository _purchaseRepository;

        public PurchaseService()
        {
            _purchaseRepository = new PurchaseRepository();
        }

        public bool InsertPurchase(Purchase purchase)
        {
            return _purchaseRepository.InsertPurchase(purchase);
        }
    }
}
