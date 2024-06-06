using Models;
using Repositories;

namespace Controllers
{
    public class CreditCardController
    {
        private CreditCardRepository _creditCardRepository;

        public CreditCardController()
        {
            _creditCardRepository = new CreditCardRepository();
        }

        public bool InsertCreditCard(CreditCard creditCard)
        {
            return _creditCardRepository.InsertCreditCard(creditCard);
        }
    }
}
