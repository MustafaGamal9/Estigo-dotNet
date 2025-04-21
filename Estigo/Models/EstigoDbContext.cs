using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.IO;

namespace Estigo.Models
{
    public class EstigoDbContext : IdentityDbContext<ApplicationUser>
    {
        // uncomment to test the seed data
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        // _______________________________

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
                        .HasMany(c => c.Payments)
                        .WithOne(p => p.Course)
                        .HasForeignKey(p => p.CourseId)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Student>()
                  .HasMany(s => s.Courses)
                  .WithMany(c => c.students)
                  .UsingEntity<MyCourse>(
                           j => j
                     .HasOne(mc => mc.Course)
                     .WithMany()
                     .HasForeignKey(mc => mc.CourseId)
                     .OnDelete(DeleteBehavior.Restrict),
                                  j => j
                     .HasOne(mc => mc.Student)
                     .WithMany()
                     .HasForeignKey(mc => mc.StudentId)
                     .OnDelete(DeleteBehavior.Restrict),
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

            modelBuilder.Entity<Exam>()
                .Property(l => l.CreatedAt)
                .HasDefaultValueSql("GETDATE()");


            modelBuilder.Entity<Exam>()
                .Property(l => l.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<StudentExamResult>()
                .Property(l => l.ExamDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<ApplicationUser>()
                .Property(l => l.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.CoursesTaught)
                .HasForeignKey(c => c.TeacherId)  
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ApplicationUser>()
                        .Property(l => l.UpdatedAt)
                        .HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Lesson)
                .WithOne(l => l.Exam)  
                .HasForeignKey<Exam>(e => e.lessonId)  
                .OnDelete(DeleteBehavior.Cascade);  // delete the exam if the lesson is deleted

            modelBuilder.Entity<Student>()
                        .HasIndex(s => s.StudentCode)
                        .IsUnique();

            modelBuilder.Seed();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
       // public DbSet<Chapter> Chapters { get; set; }
        public DbSet<lesson> lessons { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudentExamResult> StudentExamResults { get; set; }
        public DbSet<BankOfQuestion> BankOfQuestions { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DbSet<MyCourse> MyCourses { get; set; }

    }
}

