using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Domain;
using Domain.Models;

namespace Service.Context
{
    public class DesafioContext : DbContext
    {
        public DesafioContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Domain.Models.Customer> Customers { get; set; }
        
    }
}
