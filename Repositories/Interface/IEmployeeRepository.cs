using Models;

namespace Repositories.Interface
{
    public interface IEmployeeRepository
    {
        bool InsertEmployee(Employee employee);
    }
}
