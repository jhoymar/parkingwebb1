using Microsoft.EntityFrameworkCore;
using parkingwebb1.Data.Entities;

namespace parkingwebb1.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
    }
}

