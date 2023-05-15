using System.Globalization;
using BlazorSampleCrud.Core.Services.Interfaces;
using BlazorSampleCrud.DataAccessLayer.Entities.Models;
using BlazorSampleCrud.DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace BlazorSampleCrud.Core.Services.ConcreateClass
{
    public class CustomerService:ICustomerService
    {
        private ICustomerRepository<Customer> _customerRepository;

        public CustomerService(ICustomerRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void Dispose()
        {
            _customerRepository?.Dispose();
        }

        public async Task<List<Customer>> GetAllCustomer()
        {
            return await _customerRepository.GetEntityQuery().ToListAsync();
        }

        public async Task<Customer?> GetCustomerById(int id)
        {
            return await _customerRepository.GetEntityById(id);
        }

        public async Task AddCustomer(Customer customer)
        {
            await _customerRepository.AddEntity(customer);
        }

        public async Task DeleteCustomerById(int id)
        {
            await _customerRepository.DeleteEntityById(id);
        }

        public void DeleteCustomer(Customer customer)
        {
             _customerRepository.DeleteEntity(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
             _customerRepository.UpdateEntity(customer);
        }

        public async Task SaveChanges()
        {
            await _customerRepository.SaveChanges();
        }
    }
}
