using Models;
using Services;

namespace Controllers
{
    public class EmployeeController
    {
        private EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public bool InsertEmployee(Employee employee)
        {
            return _employeeService.InsertEmployee(employee);
        }
    }
}
