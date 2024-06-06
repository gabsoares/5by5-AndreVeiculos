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
    public class RoleService
    {
        private IRoleRepository _roleRepository;

        public RoleService()
        {
            _roleRepository = new RoleRepository();
        }

        public bool InsertRole(Role role)
        {
            return _roleRepository.InsertRole(role);
        }
    }
}
