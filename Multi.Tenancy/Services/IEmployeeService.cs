using Multi.Tenancy.Entities;

namespace Multi.Tenancy.Services
{
    public interface IEmployeeService
    {
        Task<Employee> CreatedAsync(Employee employeee);
        Task<Employee?> GetByIdAsync(int id);
        Task<IReadOnlyList<Employee>> GetAllAsync();
    }
}
