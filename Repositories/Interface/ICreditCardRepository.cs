﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface ICreditCardRepository
    {
        bool InsertCreditCard(CreditCard creditCard);
    }
}
