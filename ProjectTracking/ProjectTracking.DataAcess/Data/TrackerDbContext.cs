using Microsoft.EntityFrameworkCore;
using ProjectTracking.Entities;

namespace ProjectTracking.DataAcess.Data
{
    public class TrackerDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<TaskInProject> Tasks { get; set; }

        public TrackerDbContext(DbContextOptions<TrackerDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(

                new Project() { Id = 1, Name = "Örnek Proje", CompletePercent = 0 }

                );


        }
    }
}
