using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Customer
{

    /// <summary>
    /// Interface for Customer Service
    /// </summary>
    public interface ICustomerService
    {
        /// <summary>
        /// Get the Cutomer from database by id
        /// </summary>
        /// <param name="id">Customer id</param>
        /// <returns>Object of Domain.Models.Customer</returns>
        Domain.Models.Customer GetById(int id);
        /// <summary>
        /// Get the Customer from dataabase by Email
        /// </summary>
        /// <param name="Email">Customer Email</param>
        /// <returns>Object of Domain.Models.Customer</returns>
        Domain.Models.Customer GetByEmail(string Email);
        /// <summary>
        /// Get all Customers from database
        /// </summary>
        /// <returns>List of Domain.Models.Customer</returns>
        List<Domain.Models.Customer> GetAll();
        /// <summary>
        /// Save (insert/update) a customer to database
        /// </summary>
        /// <param name="customer">Object of customer to insert</param>
        void Save(Domain.Models.Customer customer);
       
    }
}
