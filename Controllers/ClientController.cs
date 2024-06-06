using Models;
using Services;

namespace Controllers
{
    public class ClientController
    {
        private ClientService _clientService;

        public ClientController()
        {
            _clientService = new ClientService();
        }

        public bool InsertClient(Client client)
        {
            return _clientService.InsertClient(client);
        }
    }
}
