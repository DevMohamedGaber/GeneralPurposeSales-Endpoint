using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeneralPurposeSalesAppEndpoint.Models
{
    public class AppDBContext : IdentityDbContext
    {
        public DbSet<Offer> offers { get; set; }
        public DbSet<Sale> sales { get; set; }

        public AppDBContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
