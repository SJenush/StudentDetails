
using Microsoft.EntityFrameworkCore;
using StudentDetails.Models.Domains;

namespace StudentDetails.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
         public DbSet<Student> Stud_detail { get; set; }
        public DbSet<School> M_School { get; set; }
        public DbSet<Marks> Stud_Marks { get; set; }
        public DbSet<District>M_District { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne<Student>()
                .WithOne()
                .HasForeignKey<Student>(s => s.School_Code);

            base.OnModelCreating(modelBuilder);
        }
    }
}
