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
    public class AdressService
    {
        private IAdressRepository _adressRepository;

        public AdressService()
        {
            _adressRepository = new AdressRepository();
        }

        public bool InsertAdress(Adress adress)
        {
            return _adressRepository.InsertAdress(adress);
        }
    }
}
