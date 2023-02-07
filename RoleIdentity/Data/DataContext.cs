using Microsoft.EntityFrameworkCore;
using RoleIdentity.Models;

namespace RoleIdentity.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }



        public DbSet<User> Users => Set<User>();
        public DbSet<Tip> Tips => Set<Tip>();

    }
}
