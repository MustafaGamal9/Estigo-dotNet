using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.IO;

namespace Estigo.Models
{
    public class EstigoDbContext : IdentityDbContext<ApplicationUser>
    {
        //// uncomment to test the seed data
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        //}

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

           // modelBuilder.Entity<ApplicationUser>()
           //     .Property(u => u.CreatedAt)
           //     .HasDefaultValueSql("GETDATE()");

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

            /* Home Page Data ( most popular courses | meet our instructors ) 

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Mathematics" },
                new Category { Id = 2, Name = "Physics" },
                new Category { Id = 3, Name = "Biology" },
                new Category { Id = 4, Name = "Chemistry" },
                new Category { Id = 5, Name = "English" },
                new Category { Id = 6, Name = "History" },
                new Category { Id = 7, Name = "Geography" },
                new Category { Id = 8, Name = "Computer Science" },
                new Category { Id = 9, Name = "Art" },
                new Category { Id = 10, Name = "Music" }
            );

            // Seed Teachers
            var biologyImageBytes = File.ReadAllBytes("wwwroot/image/Biology/biology-a2.jpg"); // Load image as byte array

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = "teacher1-guid", Name = "Mustafa", Email = "teacher1@estigo.com", NormalizedEmail = "TEACHER1@ESTIGO.COM", UserName = "teacher1@estigo.com", NormalizedUserName = "TEACHER1@ESTIGO.COM", Gender = "Male", Subject = "Mathematics", Notes = "Expert in Algebra", Role = "Teacher", image = biologyImageBytes },
                new Teacher { Id = "teacher2-guid", Name = "Mahmoud", Email = "teacher2@estigo.com", NormalizedEmail = "TEACHER2@ESTIGO.COM", UserName = "teacher2@estigo.com", NormalizedUserName = "TEACHER2@ESTIGO.COM", Gender = "Female", Subject = "Physics", Notes = "Specialist in Mechanics", Role = "Teacher", image = biologyImageBytes },
                new Teacher { Id = "teacher3-guid", Name = "Ahmed", Email = "teacher3@estigo.com", NormalizedEmail = "TEACHER3@ESTIGO.COM", UserName = "teacher3@estigo.com", NormalizedUserName = "TEACHER3@ESTIGO.COM", Gender = "Male", Subject = "Biology", Notes = "Experienced in Cell Biology", Role = "Teacher", image = biologyImageBytes },
                new Teacher { Id = "teacher4-guid", Name = "Mohamed", Email = "teacher4@estigo.com", NormalizedEmail = "TEACHER4@ESTIGO.COM", UserName = "teacher4@estigo.com", NormalizedUserName = "TEACHER4@ESTIGO.COM", Gender = "Female", Subject = "Chemistry", Notes = "Passionate about Organic Chemistry", Role = "Teacher", image = biologyImageBytes },
                new Teacher { Id = "teacher5-guid", Name = "Kareem", Email = "teacher5@estigo.com", NormalizedEmail = "TEACHER5@ESTIGO.COM", UserName = "teacher5@estigo.com", NormalizedUserName = "TEACHER5@ESTIGO.COM", Gender = "Male", Subject = "English", Notes = "Loves English Literature", Role = "Teacher", image = biologyImageBytes }
            );

            var seedDate = new DateTime(2024, 3, 29); // Fixed date for seeding


<<<<<<< Updated upstream
=======

            modelBuilder.Entity<ApplicationUser>()
                .Property(l => l.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");

>>>>>>> Stashed changes

            // Seed Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, CourseTitle = "Advanced Mathematics", Description = "Comprehensive course covering advanced mathematical concepts", Price = 199, Available = true, CategoryId = 1, TeacherId = "teacher1-guid", CreatedAt = seedDate, Logo = biologyImageBytes },
                new Course { CourseId = 2, CourseTitle = "Physics Fundamentals", Description = "Learn the basics of physics and mechanics", Price = 149, Available = true, CategoryId = 2, TeacherId = "teacher2-guid", CreatedAt = seedDate, Logo = biologyImageBytes },
                new Course { CourseId = 3, CourseTitle = "Biology Essentials", Description = "Understanding life sciences and cellular biology", Price = 179, Available = true, CategoryId = 3, TeacherId = "teacher3-guid", CreatedAt = seedDate, Logo = biologyImageBytes },
                new Course { CourseId = 4, CourseTitle = "Chemistry Basics", Description = "Introduction to chemical principles and reactions", Price = 159, Available = true, CategoryId = 4, TeacherId = "teacher4-guid", CreatedAt = seedDate, Logo = biologyImageBytes },
                new Course { CourseId = 5, CourseTitle = "English Literature", Description = "Explore classic and modern English literature", Price = 129, Available = true, CategoryId = 5, TeacherId = "teacher5-guid", CreatedAt = seedDate, Logo = biologyImageBytes }
            );

            */



        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<lesson> lessons { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudentExamResult> StudentExamResults { get; set; }
        public DbSet<BankOfQuestion> BankOfQuestions { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}

