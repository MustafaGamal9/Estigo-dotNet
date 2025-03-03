using Estigo.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Estigo.Models
{
    public class EstigoDbContext : IdentityDbContext<ApplicationUser>
    {

        

       //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)); }
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

                    //modelBuilder.Entity<ApplicationUser>()
                    //    .Property(u => u.CreatedAt)
                    //    .HasDefaultValueSql("GETDATE()");


            modelBuilder.Entity<Student>()
                  .HasMany(s => s.Courses)
                  .WithMany(c => c.students)
                  .UsingEntity<MyCourse>(
                           j => j
                     .HasOne(mc => mc.Course)
                     .WithMany() 
                     .HasForeignKey(mc => mc.CourseId),
                          j => j
                     .HasOne(mc => mc.Student)
                     .WithMany() 
                     .HasForeignKey(mc => mc.StudentId),
                          j =>
                           {
                               j.ToTable("MyCourses"); 
                              j.HasKey(mc => mc.MyCourseId); 
                                          
                          });


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

            modelBuilder.Entity<lesson>()
                .Property(l => l.lessonTitle)
                .HasMaxLength(100);

            modelBuilder.Entity<lesson>()
                .Property(l => l.lessonContent)
                .HasMaxLength(250);

            modelBuilder.Entity<lesson>()
                .Property(l => l.lessonVideo)
                .HasMaxLength(250);

            modelBuilder.Entity<lesson>()
                .Property(l => l.lessonDescription)
                .HasMaxLength(250);

            modelBuilder.Entity<lesson>()
                .Property(l => l.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<lesson>()
                .Property(l => l.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");


            //// Seed Categories
            //modelBuilder.Entity<Category>().HasData(
            //    new Category { Id = 1, Name = "Science" },
            //    new Category { Id = 2, Name = "Mathematics" }
            //);

            //// Seed Courses
            //modelBuilder.Entity<Course>().HasData(
            //    new Course { CourseId = 1, CategoryId = 1, CourseTitle = "Biology 101", Price = 100, Available = true },
            //    new Course { CourseId = 2, CategoryId = 1, CourseTitle = "Physics 101", Price = 120, Available = true },
            //    new Course { CourseId = 3, CategoryId = 2, CourseTitle = "Calculus I", Price = 90, Available = true }
            //);

            //// Seed Students (Important: Use consistent IDs and Hash passwords if needed for Identity)
            //var passwordHasher = new PasswordHasher<ApplicationUser>(); // Need to hash passwords for Identity
            //modelBuilder.Entity<Student>().HasData(
            //    new Student { Id = "student1-id", Name = "Alice Student", UserName = "alice@example.com", Email = "alice@example.com", Phone = "111-111-1111", Gender = "Female", PasswordHash = passwordHasher.HashPassword(null, "P@$$wOrd1") },
            //    new Student { Id = "student2-id", Name = "Bob Student", UserName = "bob@example.com", Email = "bob@example.com", Phone = "222-222-2222", Gender = "Male", PasswordHash = passwordHasher.HashPassword(null, "P@$$wOrd2") },
            //    new Student { Id = "student3-id", Name = "Charlie Student", UserName = "charlie@example.com", Email = "charlie@example.com", Phone = "333-333-3333", Gender = "Other", PasswordHash = passwordHasher.HashPassword(null, "P@$$wOrd3") }
            //);

            //// Seed Payments (Simulate purchases for some students)
            //modelBuilder.Entity<Payment>().HasData(
            //    new Payment { PaymentId = 1, StudentId = "student1-id", CourseId = 1, PurchaseDate = DateTime.UtcNow.AddDays(-10), PaymentMethod = "Credit Card" }, // Alice bought Biology 101
            //    new Payment { PaymentId = 2, StudentId = "student1-id", CourseId = 2, PurchaseDate = DateTime.UtcNow.AddDays(-5), PaymentMethod = "PayPal" },   // Alice bought Physics 101
            //    new Payment { PaymentId = 3, StudentId = "student2-id", CourseId = 3, PurchaseDate = DateTime.UtcNow.AddDays(-2), PaymentMethod = "Credit Card" }  // Bob bought Calculus I
            //    // Charlie hasn't bought any courses (no Payment record for Charlie)
            //);

            //// Seed MyCourses (Crucially, link students to courses based on payments - or however your logic works)
            //modelBuilder.Entity<MyCourse>().HasData(
            //    new MyCourse { MyCourseId = 1, StudentId = "student1-id", CourseId = 1, EnrollmentDate = DateTime.UtcNow.AddDays(-10) }, // Alice enrolled in Biology 101
            //    new MyCourse { MyCourseId = 2, StudentId = "student1-id", CourseId = 2, EnrollmentDate = DateTime.UtcNow.AddDays(-5) },  // Alice enrolled in Physics 101
            //    new MyCourse { MyCourseId = 3, StudentId = "student2-id", CourseId = 3, EnrollmentDate = DateTime.UtcNow.AddDays(-2) }   // Bob enrolled in Calculus I
            //    // Charlie is not in MyCourses (not enrolled)
            //);

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<lesson> lessons { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DbSet<MyCourse> MyCourses { get; set; }
    }
}