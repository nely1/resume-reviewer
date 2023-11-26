using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;
using ResumeReviewer.Models;

namespace ResumeReviewer.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Job> Jobs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .HasOne(b => b.Job)
                .WithMany(a => a.Applications)
                .HasForeignKey(b => b.JobId);

            modelBuilder.Entity<Job>()
                .HasOne(b => b.Company)
                .WithMany(a => a.Jobs)
                .HasForeignKey(b => b.CompanyId);
        }
    }
}
