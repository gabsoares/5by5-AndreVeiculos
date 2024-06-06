using Models;
using Services;

namespace Controllers
{
    public class RoleController
    {
        private RoleService _roleService;

        public RoleController()
        {
            _roleService = new RoleService();
        }

        public bool InsertRole(Role role)
        {
            return _roleService.InsertRole(role);
        }
    }
}
