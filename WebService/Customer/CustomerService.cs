using System.Collections.Generic;
using Domain.Models;
using Service.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Service.Customer
{
    /// <summary>
    /// Customer service
    /// </summary>
    public class CustomerService : ICustomerService
    {

        private readonly DesafioContext _desafioContext;

        /// <summary>
        /// Initializes a new instance of the Customer Service
        /// </summary>
        /// <param name="desafioContext"></param>
        public CustomerService(DesafioContext desafioContext)
        {
            _desafioContext = desafioContext;
        }

        /// <summary>
        /// Save (Insert/Update) a customer to database
        /// </summary>
        /// <param name="customer">Object of customer to insert</param>
        public void Save(Domain.Models.Customer customer)
        {
            var testCustomer = GetByEmail(customer.Email);
            if (testCustomer != null)
            {
                customer.Id = testCustomer.Id;

            }
            _desafioContext.Customers.Update(customer);
            _desafioContext.SaveChanges();
        }

        /// <summary>
        /// Get all Customers from database
        /// </summary>
        /// <returns>List of Domain.Models.Customer</returns>
        public List<Domain.Models.Customer> GetAll()
        {
            return _desafioContext.Customers.ToList();
        }

        /// <summary>
        /// Get the Cutomer from database by id
        /// </summary>
        /// <param name="id">Customer id</param>
        /// <returns>Object of Domain.Models.Customer</returns>
        public Domain.Models.Customer GetById(int id)
        {
            return _desafioContext.Customers.FirstOrDefault(c => c.Id == id);
        }

        /// <summary>
        /// Get the No Tracking Cutomer from database by Email
        /// </summary>
        /// <param name="id">Customer id</param>
        /// <returns>No Tracking Object of Domain.Models.Customer</returns>        
        public Domain.Models.Customer GetByEmail(string email)
        {
            return _desafioContext.Customers.AsNoTracking().FirstOrDefault(c => c.Email.Equals(email));
        }




    }
}
