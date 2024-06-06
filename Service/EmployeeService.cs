using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class EmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public bool InsertEmployee(Employee employee)
        {
            return _employeeRepository.InsertEmployee(employee);
        }
    }
}
