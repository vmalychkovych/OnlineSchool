using Microsoft.EntityFrameworkCore;
using OnlineSchool.Models;

namespace OnlineSchool.DB.AppDBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Roles = "Admin" },
                new Role { Id = 2, Roles = "Teacher" },
                new Role { Id = 3, Roles = "Study" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, RoleId = 1, Login="Admin", Password="admin" },
                new User { Id = 2, RoleId = 2, Login="teacher", Password="teacher" },
                new User { Id = 3, RoleId = 3, Login="study", Password="study" }
            );
        }
    }
}
