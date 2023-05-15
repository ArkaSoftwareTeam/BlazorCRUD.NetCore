using BlazorSampleCrud.DataAccessLayer.Entities.Models;

namespace BlazorSampleCrud.Core.Services.Interfaces
{
    public interface ICustomerService:IDisposable
    {
        Task<List<Customer>> GetAllCustomer();
        Task<Customer?> GetCustomerById(int id);
        Task AddCustomer(Customer customer);
        Task DeleteCustomerById(int id);
        void DeleteCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Task SaveChanges();
    }
}
