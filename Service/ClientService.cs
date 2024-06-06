using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class ClientService
    {
        private IClientRepository _clientRepository;

        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public bool InsertClient(Client client)
        {
            return _clientRepository.InsertClient(client);
        }
    }
}
