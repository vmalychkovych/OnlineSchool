using Microsoft.EntityFrameworkCore;
using OnlineSchool.Models;

namespace OnlineSchool.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Roles = "Admin" },
                new Role { Id = 2, Roles = "Teacher" },
                new Role { Id = 3, Roles = "Study" }
            );
        }
    }
}
