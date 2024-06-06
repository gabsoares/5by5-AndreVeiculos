using Models;
using Services;

namespace Controllers
{
    public class SaleController
    {
        private SaleService _saleService;

        public SaleController()
        {
            _saleService = new SaleService();
        }

        public bool InsertSale(Sale sale)
        {
            return _saleService.InsertSale(sale);
        }
    }
}
