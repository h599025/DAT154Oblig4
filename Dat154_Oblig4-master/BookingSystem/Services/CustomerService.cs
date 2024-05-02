using BookingSystem.Models;
using BookingSystem.Repositories;

namespace BookingSystem.Services
{


    public interface ICustomerService
    {
        public bool ValidatePassword(string password, Customer customer);

        public Customer GetCustomerByEmail(string email);

        public bool ValidCustomer(Customer customer);

        public void AddCustomer(Customer customer);

    }

    public  class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;


        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public bool ValidatePassword(string password, Customer customer)
        {
            return password!= null && customer != null && password == customer.Password;
        }

        public  Customer GetCustomerByEmail(string email)
        {
            return customerRepository.GetCustomer(email);
        }

        public bool ValidCustomer(Customer customer)
        {
            if (customer == null || customer.Email == null || customer.Password == null || customer.Name == null || GetCustomerByEmail(customer.Email) != null)
            {
                return false;
            }

            return true;

        }

        public void AddCustomer(Customer customer)
        {
            customerRepository.AddCustomer(customer);
        }


    }
}
