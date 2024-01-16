using Microsoft.EntityFrameworkCore;
using Pakwear.Shared;
using Client.Shared;
using System.Collections.Generic;
using Client.Shared;

namespace WebApiGrey.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
       
        public DbSet<cUSTOMERR> Customers { get; set; } // Add this line for the cUSTOMERR model
    }
}
