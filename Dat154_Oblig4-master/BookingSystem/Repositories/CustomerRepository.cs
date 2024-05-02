using Microsoft.EntityFrameworkCore;
using BookingSystem.Models;


namespace BookingSystem.Repositories
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        Customer GetCustomer(string email);

    }
    public class CustomerRepository : ICustomerRepository
    {

        private dat154Context dx = new();

        public void AddCustomer(Customer customer)
        {
            dx.Customers.Add(customer);
            dx.SaveChanges();
        }


        public Customer? GetCustomer(string email)
        {
            return dx.Customers.Include(r => r.Bookings).SingleOrDefault(c => c.Email == email);
        }
    }
}