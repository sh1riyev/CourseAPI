using System.Reflection;
using Domain.Configuration;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<GroupStudent> GroupStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupConfiguration).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}