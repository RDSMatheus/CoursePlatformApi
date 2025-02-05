using CoursePlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace CoursePlatform.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses {  get; set; } 
        public DbSet<Module> Modules { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique(); 

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Cpf)
                .IsUnique(); 

            modelBuilder.Entity<Course>().HasIndex(u => u.Title).IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}
