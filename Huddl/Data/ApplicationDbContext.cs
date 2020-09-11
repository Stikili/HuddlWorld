using Huddl.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Huddl.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        public DbSet<MerchantEstablishment> MerchantEstablishment { get; set; }
        public DbSet<Beverages> Beverages { get; set; }

        public DbSet<FixtureSchedule> FixtureSchedule { get; set; }
    }
}




