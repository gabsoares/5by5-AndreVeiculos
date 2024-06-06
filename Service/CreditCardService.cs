using Models;
using Repositories;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CreditCardService
    {
        private ICreditCardRepository _creditCardRepository;

        public CreditCardService()
        {
            _creditCardRepository = new CreditCardRepository();
        }

        public bool InsertCreditCar(CreditCard creditCard)
        {
            return _creditCardRepository.InsertCreditCard(creditCard);
        }
    }
}
