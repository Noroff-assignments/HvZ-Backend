using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace hvz_backend.Models
{
    public class HvZDbContext : DbContext
    {
        // Sets the tables for the database

        public HvZDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
