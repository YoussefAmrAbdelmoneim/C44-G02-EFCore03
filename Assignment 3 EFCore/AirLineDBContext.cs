using Assignment_1_EFCore.AirlinesModels;
using Microsoft.EntityFrameworkCore;

namespace Assignment_3_EFCore
{
    internal class AirLineDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=AirlineDB2;Trusted_Connection=true;TrustServerCertificate=true");
        }
    public DbSet<Aircraft> Aircraft { get; set; }
    public DbSet<Airline> Airline { get; set; }
    public DbSet<Airline_Phones> airline_Phones { get; set; }
    public DbSet<Transaction> transactions { get; set; }
    public DbSet<Employee> employees { get; set; }
    public DbSet<Emp_Qualifications> emp_Qualifications { get; set; }
    public DbSet<Route> routes { get; set; }
    public DbSet<Aircraft_Routes> aircraft_Routes { get; set; }

}
}
