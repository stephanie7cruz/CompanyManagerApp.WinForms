using System.Data.Entity; // Usar EF 6 en lugar de EF Core

namespace CompanyManagerApp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public AppDbContext() : base("name=CompanyDbConnection")
        {
        }
    }
}
