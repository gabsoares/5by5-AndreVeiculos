using Models;
using Services;

namespace Controllers
{
    public class PurchaseController
    {
        private PurchaseService _purchaseService;

        public PurchaseController()
        {
            _purchaseService = new PurchaseService();
        }

        public bool InsertPurchase(Purchase purchase)
        {
            return _purchaseService.InsertPurchase(purchase);
        }
    }
}