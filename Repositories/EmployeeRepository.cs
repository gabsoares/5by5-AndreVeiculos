using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;
namespace Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private string Conn;

    public EmployeeRepository()
    {
        Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }
    public bool InsertEmployee(Employee employee)
    {
        bool status = false;
        try
        {
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(Employee.INSERT, new
                {
                    CPF = employee.CPF,
                    Name = employee.Name,
                    DateBirth = employee.DateOfBirth,
                    AdressId = employee.Adress?.Id,
                    Phone = employee.Phone,
                    Email = employee.Email,
                    Comission = employee.Comission,
                    ComissionValue = employee.ComissionValue,
                    RoleId = employee.Role.Id
                });
                db.Close();
            }
            status = true;
        }
        catch (Exception)
        {
            throw;
        }
        return status;
    }
}
