using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IAdressRepository
    {
        bool InsertAdress(Adress adress);
    }
}
