using AnalysisScore.Models;
using System.Data.Entity;

namespace AnalysisScore.Data
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MFUNCTION");
            base.OnModelCreating(modelBuilder);
        }
    }
}
