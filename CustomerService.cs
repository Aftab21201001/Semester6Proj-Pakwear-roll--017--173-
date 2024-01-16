using Microsoft.EntityFrameworkCore;
using Pakwear.Context;
using Pakwear.Model;
using System.ComponentModel.DataAnnotations;

namespace Pakwear.Data
{
    public class CustomerService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CustomerService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //List of Customers
        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _applicationDbContext.Customers.ToListAsync();
        }

        //Add Customers
        public async Task<bool> InsertCustomer(Customer customer)
        {
            await _applicationDbContext.Customers.AddAsync(customer);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get Employee By Id  
        public async Task<Customer> GetCustomerById(int id)
        {
            Customer customer = await _applicationDbContext.Customers.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return customer;
        }

        //Update Customer
        public async Task<bool> UpdateCustomer(Customer customer)
        {
            _applicationDbContext.Customers.Update(customer);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete Customers
        public async Task<bool> DeleteCustomer(Customer customer)
        {
            _applicationDbContext.Customers.Remove(customer);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }

}

