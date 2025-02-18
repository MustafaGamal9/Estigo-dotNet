using Estigo.Migrations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Estigo.Models
{
    public class EstigoDbContext : IdentityDbContext<ApplicationUser>
    {
        public EstigoDbContext(DbContextOptions<EstigoDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تحديد "Discriminator" تلقائيًا في الجدول AspNetUsers
            modelBuilder.Entity<ApplicationUser>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Student>("Student")
                .HasValue<Admin>("Admin")
                .HasValue<Teacher>("Teacher")
                .HasValue<Parent>("Parent");

            modelBuilder.Entity<Course>()
                .Property(c => c.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Course>()
                .Property(c => c.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Chapter>()
                .Property(c => c.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Chapter>()
                .Property(c => c.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");


        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
    }
}
