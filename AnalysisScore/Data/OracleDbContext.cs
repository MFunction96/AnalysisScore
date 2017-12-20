using AnalysisScore.Models;
using System.Data.Entity;

namespace AnalysisScore.Data
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public class OracleDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Student> Students { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Score> Scores { get; set; }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("MFUNCTION");
            modelBuilder.Entity<Score>().HasKey(k => new { k.Score_Time, k.Stu_Id });
        }
    }
}
