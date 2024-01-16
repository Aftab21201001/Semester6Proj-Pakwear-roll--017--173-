using Microsoft.EntityFrameworkCore;
using Pakwear.Data;
using Pakwear.Model;
using System.Collections.Generic;

namespace Pakwear.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }


}
