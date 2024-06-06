using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class SaleService
    {
        private ISaleRepository _saleRepository;

        public SaleService()
        {
            _saleRepository = new SaleRepository();
        }

        public bool InsertSale(Sale sale)
        {
            return _saleRepository.InsertSale(sale);
        }
    }
}
