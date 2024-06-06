using Models;
using Services;

namespace Controllers
{
    public class AdressController
    {
        private AdressService _adressService;

        public AdressController()
        {
            _adressService = new AdressService();
        }

        public bool InsertAdress(Adress adress)
        {
            return _adressService.InsertAdress(adress);
        }
    }
}
