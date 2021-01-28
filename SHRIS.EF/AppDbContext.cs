using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SHRIS.EF.Extensions;
using SHRIS.EF.Models;
using SHRIS.EF.Models.Interface;

namespace SHRIS.EF
{
    class AppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
                {
                    entityType.AddSoftDeleteQueryFilter();
                }
            }
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PersonIdentificationType> PersonIdentificationTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PersonalDetail> PersonalDetails { get; set; } 
        public DbSet<PersonIdentification> PersonIdentifications { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}
